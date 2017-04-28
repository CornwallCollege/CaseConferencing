/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.RuntimePlatform.Email {
    public abstract class SimpleCss<Type> {
        private IEnumerable<SimpleCssStyleDefinition> styleDefinitions;
        private HashSet<string> allCssClasses;

        protected Func<IEnumerable<Pair<string, string>>, IEnumerable<Pair<string, string>>> StyleSelectorFilter {
            get; set;
        }

        public SimpleCss(string css) {
            styleDefinitions = SimpleCssParser.GetStyleDefinitions(css, out allCssClasses);
        }

        //TODO make processing methods here instead of having these properties
        public IEnumerable<SimpleCssStyleDefinition> StyleDefinitions {
            get { return styleDefinitions; }
        }

        public HashSet<string> AllCssClasses {
            get { return allCssClasses; }
        }
        
        protected abstract bool MatchMethod(Type element, SimpleCssSelectorElement selectorElement);
        protected abstract Type GetParentMethod(Type element);
        protected abstract void SetStyleMethod(Type element, string style);

        public virtual void SetStyleFor(Type element) {
            SetStyleMethod(element, GetStyleFor(element));
        }


        private string GetStyleFor(Type element) {
            var matching = StyleDefinitions.Where(def => def.Matches(element, MatchMethod, GetParentMethod))
                                           .OrderByDescending(def => def.Specificity, SimpleCssStyleDefinition.SpecificityComparer.Instance)
                                           .ThenByDescending(def => def.Index);

            var styles = GetDistinctPrioritizedStyles(matching);

            if (StyleSelectorFilter != null) {
                styles = StyleSelectorFilter(styles);
            }

            return styles.Select(pair => pair.First + ": " + pair.Second + ";")
                         .StrCat(" ");
        }

        private IEnumerable<Pair<string, string>> GetDistinctPrioritizedStyles(IEnumerable<SimpleCssStyleDefinition> definitions) {
            var styleList = new List<Pair<string, string>>();

            var elements = new HashSet<string>();

            // this list is already sorted from bottom to top (specificity and order of definition)
            foreach (SimpleCssStyleDefinition cssDefinition in definitions) {
                
                // but properties inside are not - so iterate by reverse order
                foreach (Pair<string, string> property in cssDefinition.PropertyDefinitions.Reverse()) {

                    //we need to check if in our list we already have a definition that smashes this one
                    if (!IsPropertySmashed(elements, property.First)) {
                        styleList.Insert(0, property);
                        elements.Add(property.First);
                    }
                }
            }

            // we want the first element we inserted to be returned last
            return styleList;
        }

        private bool IsPropertySmashed(HashSet<string> existing, string property) {

            // border is more general than border-style
            // border-bottom is more general than border-bottom-width
            if (property.Contains('-')) {
                foreach (string definition in existing) {
                    if (property.Contains(definition)) {
                        return true;
                    }
                }
            } else {
                // check if already exists
                return existing.Contains(property);
            }
            return false;
        }
    }
}