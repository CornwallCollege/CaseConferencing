﻿/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace ssCaseConferencing {
	public class _RunningInfo: RunningInfo
	{
		private static bool alreadyRegistered = false;
		public static void Register() {
			if (alreadyRegistered)
			return;

			InitializeRunningInfo();
			if (!RunningInfo.IsInitialized) {
				// Retry
				InitializeRunningInfo();
				if (!RunningInfo.IsInitialized) {
					throw new Exception("Failed initializing RunningInfo: " + RunningInfo.InitializingErrorMessage);
				}
			}

			RunningInfo.EspaceUID = "749c19b2-8452-4500-9764-67eb95913009";
			using(Transaction tran = DatabaseAccess.ForSystemDatabase.GetCommitableTransaction()) {
				if (espaceId == 0) {
					throw new Exception("Failed initializing RunningInfo: null eSpace identifier.");
				}

				areaId = DBRuntimePlatform.Instance.GetOrCreateArea(tran, espaceId, userId);
				RegisterInfo(tran);
				tran.Commit();
			}
		}

		public static void RegisterInfo(Transaction tran) {
			if (alreadyRegistered)
			return;
			alreadyRegistered = true;
			if (RunningInfo.EspaceName == "CaseConferencing") {
				Reset(tran);
				RunningInfo.RegisterEntryPoint(tran, "Session", false);
				RunningInfo.RegisterEntryPoint(tran, "Reporting", false);
				RunningInfo.RegisterEntryPoint(tran, "Progress_Report", false);
				RunningInfo.RegisterEntryPoint(tran, "MakingLearningWork", true);
				RunningInfo.RegisterEntryPoint(tran, "Home", false);
				RunningInfo.RegisterEntryPoint(tran, "Courses", false);
				RunningInfo.RegisterEntryPoint(tran, "Entry1", false);
				RunningInfo.RegisterEntryPoint(tran, "Learners", false);
				RunningInfo.RegisterEntryPoint(tran, "Backoffice", false);
				RunningInfo.RegisterEntryPoint(tran, "AutoCompleteBank", false);
				RunningInfo.RegisterEntryPoint(tran, "SafeguardingReport", false);
				RunningInfo.RegisterEntryPoint(tran, "Safeguarding", false);
				RunningInfo.RegisterEntryPoint(tran, "Default", false);
			}
			RegisterAssembly(tran, "CaseConferencing", "g0uLCim5I0oi4f+yckzixg", false, "1", "QQJwCkGhCxsjtT_ejR61nw:LWOvwZcad3R9ELLAVAvjfQ\nupBmDoAs+EqQrx7aTaU3Sw:15YWu5nHJYqoopwY1PWPzA\nPkakDiHIHJgyPCLQc+hGgw:1M1iPV5E7JWjfDP6GYgixw\n9_3FEmTqXU9Xd9blamDm+A:Fmk8ENDI09PYPEnIXLsnSg\n8AVsGOWawEKOvsJEB6asgg:iA4IAqeBjmTUUzjaDMdQTw\n9I1AM_sXKUGOueuMRKEyiQ:bUAcKxVj8mN3vsi0_n2lxg\nY0YgO+CdA+mNBx_jxn8DZw:TtuI292w84AopOnIH8C10w\njEkkPP0QIk2eOfGm3HtoWQ:_X7llnfUbwH6CIzkkAyVbA\nHCEDQtjuxEyCWrXFDTtPxA:8yucHyYBfH27xD4+KHfT9g\nbYxARVgzPSGuuGhldCiosQ:iTlsGOMfIItD6eJrGWIuBw\nu75CRY2Rd0OLlne8gCUOFQ:jmQihq4pR57y2GbQ+QUbkg\nrVX2Rbeqx0yLdkc7MMi4Bw:hDiEgvTSsR0N5ZTL0hYZsA\ni6SCYM_2LU6Vxmk4JPLvZw:kSpgAPvszG1RhdE_MP+hiA\nXsSBcBkm20O9MGFs22o4aA:Ua2TEbpSYHoWstZojdxdrA\n_AlAd77Q40qB90+b+ar8kg:Xb+HIfiuULXdkWezbUS7oA\nHSdjgPf05EGi6PhLqINYfA:GUDJE8EYSSjyvsMMlc3kDQ\n5tUHmrdnGUGm6Boh64E1fQ:MzZYZnu9hwMNGasulQlPqg\nxxB5peNFZU29QzS3g6Bk7w:oGuCUcmyGLen34+v7uegoQ\nAEbEqNPIhUaaBTyHQ6Psow:V1D+uLfkbyXPli5P2CfN0g\nXfBUqW7vZ0Gl112pOog_Tw:Qqku6qM2R73f1rQOu0Ls_w\nL75_rzVVY0+VczJB3XJQqg:k0SwBwPZpshIzSWpOT_thA\n+fBGsi8AQ0Wov+8sP61KWg:3M7zY6FOXt36dq+XTOqHCA\neFf2vkaOBE6ENCeEl_Bceg:itPs+73hc+M9Tm20jSZ4zw\nWqdCyL1C6kK32Yxh5K6klA:mIHMEh10j+MK8tlb3qJwPw\no3pt2SOJ4Eurqsl4cdSSNQ:0XEV9FvZaCSoBTkm9TvjeQ\nxhdE3bGfIUmXCvELZNpV6Q:rU93LcdxA6ZKioUPdP8sOA\nri7H5t0mdE6xX93ibb4pgg:Ddcm75+5QzGE4d_v+S2VkA\nSTQs6LsN6U28nMMYVYAMlQ:aCmtEt4GO5bsKmHKf3Pv4g\nfpAa79RrRUaQSPrU6XYoGA:8As3x0YLHKKanOzoBdD+5A\n0P_474gLvUO5of6oQVJFxg:cbOcAQi6w4ci_kdXj6Vr" +
			"xQ\nEntity5B57028B-F636-4BA3-93F9-C81CACBC5638:GCka1YSEfrmUTbRHt31lgQ");
			RunningInfo.InvokeRegister(tran, "ssCornwallCollegeData._RunningInfo, CornwallCollegeData");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "CornwallCollegeData", "UFBXCYVlLEuDN08XV4Xx7g:8uGfciXiw+9eq2LhpRbyTg\nLU2kHYz4o0+uTMPxR6WMng:uxIA2bh1WfthSURj+f0LTA\nYnAbIiw3G0esqqNFtx3KzQ:vakBCygzPAHqfHDmbl27WQ\n0dvlNAhr2EKWsXXvWV7KcQ:luy+NZuZdJDpKxX1v0H7gA\nbnLhNytYD0mFJxLFE7s+YQ:KIpKG_9s1vCSi5cf94J_3g\nNbg0P8fV8UKiPzTyK7O2cA:JzT0E1wkuwsifFiADKs4xw\nCSGaQPR3nE+ggH8wFENW7Q:k5SG7rmTwbF0LbQA69G07Q\n5SMJRzBq9USejEFlovq_CQ:GZjnEDp5n6M778HOrZwLSQ\nmu0mUJcw2U2QJ_R+JX0pmg:Ma2kyhvBuxSk6oYrZX8qwA\n+rRCUA9COUelbRoQOuj9mQ:3gO0+_Q7ogPF0jlAqB4drw\nL5L4V5PiAUWpT7gJf_dEXA:LVFfcaeWduMbqW+b4JkFow\nslNFZfRQxUSSIvwZkGNN4A:cXGA9bxs8XyKfzoE4qlwYA\nWLsDZiFBqEGRkwZU5Pqnlw:u24V1Hw+snLOo1NLFuEzsw\n9bWJaCgu_E2QgVcCzrzrmg:MqCbExD4WkJR+WHlMEH57A\n_ty3bGIJSUSPRLjOH8Iovw:X7HzPycmJkib3UBvH+wCrg\ni2cXc4jtKkeHB5V1qdUl6A:btH0ZC_dIkNLjeC6FFatWw\ndKp_deqg9kqlgVy1+7CjiA:vVHx+ljESwZAu+gPp2zFbw\nXNMbe8_lk0CsNMtIquK1kQ:tgqwy+tOUud8NJieIHS7BQ\ngL2wifRoJ0mIz5slhJPynQ:7rf3MIgKSpWOxmKF5JIp0A\nq63eivWiukSvEhVx7LpOfg:RwH3sT_Pu0CV9vKBG5PApA\njanIi+_hKU+EsYULFjl5MQ:eHcoh1MMP8HZ3rzBX_3STg\nuuFpmgpQPUqipcdwvHHsrw:vwXevjdL9hwkBD6Ctt_VZw\nr4XXn920B0OtkTmJNPkmbw:3CnKVVYDiOGoFI8WHNxBog\n22mDoScnzEWZSHlOEjwZdg:vsAxMgBcfGNnlaBJwSjVAA\n+9wQqBcbgUePB0r42+FLTg:CUhV2z5_21ng+I0TN2xD4Q\n5m02qjh0wk6wrwgqY4R78w:PBbWnXFbg5QI3gIWaL8CEA\n63I4q8RW+UeWQlTvRMTFoA:Ox9Xnnf8lWmdikVL8X7Row\nOFAKyPVaD02AdBE6wuX4zQ:YErL+jPAgUQLEKOlpaFEiQ\nrROgyFBNXU6bmVoEEQdvRg:8WYfZ_k3mLlfy_JYdQeo7A\nUvJf1wV23EKwARLLYfAadw:j+WbkyCUuQYxI" +
			"aVAesvkmw\nz88x2ZdDvUyqo0fFlGfsxA:IxpzyFQUalMMk2X21Uqirg\nRbf22Tv3VkqKn_fXob5CtA:A6atghpxhTv6O1t+H7yPMA\nm79g4QrKXEGKl20tSk7aWA:TJcQXN6jt6rKtd3eyMY7wA\nvrAx73GFK0WJmYa_Rx6Vkw:AYBPGnUJ09BqrVo7rzyT8A\n86Mg_9p0+0OVFlRbLbkpow:jDhEzwsBQuuhW2MDRt2GDw");
			RunningInfo.InvokeRegister(tran, "ssUserPermissions._RunningInfo, UserPermissions");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "UserPermissions", "Ze3XBjti6kuKCe0L0c_LEA:euAR87L75peqzsjZ7uKt6g\nLWa2GJxsDU6kkdEeZkf3BA:NXqostlDtYthI9rpFcFpUA\nFsJrIqm9d0C4RVFyAhnywQ:v84nCQV1WQXRic_88f_KfA\nn7ayKi9vb0m0wtQI13dTYw:qp43ddnUH9IANTmVVz9nMg\nAZVLUALSQ0S32ElfSaWMZA:_O9jn101QxuwYC6TyzHT4g\nLxtYXiSqpUKK_Yc6h4OHRQ:o6C8Aj_3ut75pABxNhgZJw\nhvX7b098Ok2+CmvLz+SxnQ:DlGzBoGe8V75bvArWazH0g\njwairnstMEG57OyjmhJ8KA:0D4rvApiGYIWhJMSYn3qtA\nBuBHspAKSkOCSM5kLpQBKQ:Hf0J8l7QNIsgCuyOCS94Vw\neCrEwh7x602WMOB5XL4kgQ:Y7voD9XR6oTPjuHgVAPW5g\nGrfrw7QkQ0SqhLdYV8QJAQ:cCxd_7hBFdTi9tDeU4KFCA\nJ5RKztOQzkeXuSlISouHdg:06JTFRwXkQBTWVLD__jWoQ\nek8T8GCXLECozlzoPB3XNQ:gcwKvJlFdZIGEd1Kbd9iqA");
			RunningInfo.InvokeRegister(tran, "ssHtmlToPdfConverter._RunningInfo, HtmlToPdfConverter");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "HtmlToPdfConverter", "iT2+OzplxkW3f6x1fzdkFw:GMIz7CQMunC6vWQ4GlLcGg");
			RunningInfo.InvokeRegister(tran, "ssNumberSlider._RunningInfo, NumberSlider");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "NumberSlider", "gOCpma9oMU+eB7bpfzqWCw:hgXuvBPdfRKFNB8tAKnArA");
			RunningInfo.InvokeRegister(tran, "ssCornwallCollegeFunct._RunningInfo, CornwallCollegeFunct");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "CornwallCollegeFunct", "jmhUPuBWSUKni1XhH6HGwg:NGtgjyU6nVAoVOT81Dyzyw\nZzTCY7KDi0WD9IpaEAELCg:Qlz8CWCed1Wxrj0sBqMKgQ\nDMbGaZguY0yYWc_onwr7SQ:la3jX7i3oHCcwp3a0B94og\n5SOzcc91qEqOfvhozIxkBg:BjSCpw+DnCfcVYy4hGKUGQ");
			RunningInfo.InvokeRegister(tran, "ssCharts._RunningInfo, Charts");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "Charts", "Qgl9H9SbBkqOZfc453nucA:143LFguAMBPuJLhirPTgAg\nk5CBJKrodEm3e__JgO6V7A:96rkmJaD7rKw5wkl_olC1w\nJwNSJSfAoEa49e7l5oL2gw:7RY9jGVHxeqmf4a6kN+dDA\nMwiRNIQ1kECJ0LULJqjOog:bqWiL4p56M7erY2Mvuew_g\nKd0cOOdzyUis46cGD90QKA:Vk_75eHAgVsTS24f31KV0Q\n8ZDTO7f+TU++f4xIQcBebQ:veC9_BmdN743bnWjJjgo5A\n0vIgQX5BkkiKYQTuh568Cg:Mq9guR26pe+UFdXsgHKINw\nyVYEcg8MKEudpqFNSvyWpA:gCFMPNLTBp4CC2CqQ2J+qg\nAPLbr74Ugkmr5R7VBzqIvw:GcMAosfhsSBDxHUk4Foplg\nynfltER+gEmxXuW+hRnTUQ:bbmdWNZeP7JYcV_sBYy0MA\n7XrSuims50Sj8MkWdt9Mqw:rEs_Wc2WjcJewM_5ixdTEg\n_UVxvMDs7kGd6FnuDMLDqw:k67ACa92sS3JbKemOYrE7A\neciR7vtTQ0WfwfO2TBVEcQ:7n4IJcWrT0zT4PGGT84h6Q\nFUZx_b7KLUq_swDa9D9D_g:XpM50ImhIRmfUkgIjTzM1Q\nv708_3HCjUy5C_AviNVrUQ:uhFy5r0AzEx7qr0p1czxmA");
			RunningInfo.InvokeRegister(tran, "ssUsers._RunningInfo, Users");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "Users", "QeWlzbwsP0G7pAhD2cocyw:IZxuULac+mLYqi+eZ4gFXw");
			RunningInfo.InvokeRegister(tran, "ssThemeProvider._RunningInfo, ThemeProvider");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "ThemeProvider", "schPEYYNtUSaz0Eqxf01bg:Ys_Jl2Gk_GeVGxE0BYIMjA\nAN2gN1ErrUq1pORQ6q3YAw:DLBtagajbu0nxw+w7sHZhQ\nbYxARVgzPSGuuGhldCiosQ:iTlsGOMfIItD6eJrGWIuBw\nxcJQXP+WqUKhMIbdYC8rvQ:ZRWA3Y4S_DMjL+AVV18FJA\nqFCLgR6x50CaEqEjJbd+nA:ACf2UQo2zZXMaQwz_2+gvw\nUvS95qE4qUWCh20JtgdeNg:DulRqmO72DczUgxu653kBg\nWFTa+ddQRU6enZ0TV6zn3g:Lptql0tuFSay40AxZF_JUw\nEntity5B57028B-F636-4BA3-93F9-C81CACBC5638:XYNnEiTXZszehv59PtNl1g");
			RunningInfo.InvokeRegister(tran, "ssChosen._RunningInfo, Chosen");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "Chosen", "rhRgR3WtpkulNNLsRDCJhg:NK4lEXWL1ID97Z0b_9bg4A");
			RunningInfo.InvokeRegister(tran, "ssRichWidgets._RunningInfo, RichWidgets");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "RichWidgets", "0LH4EczLZ02lVO9JnPADiw:+0U7IzWyko0JbyUQ4mEWMw\neC2rFD3CEkqrWPbgVnVC7g:BS6wXMU7h4w3mW8dhBbpAw\nCQeJF_Bei0Gns1hXhh18Rw:m0NjE0ZiQMf_AX9i82qO8Q\n_1FWIDPhm0rsiEIO4kmr9A:o3X1IiwMkcQXKckwoLkcfg\nEV_9KDysUcfkrdGiGVlxLA:LTKArjbP3HnPxSGtabVgLg\nKiJAMaMO_xi3xCL1c7rZKw:sXs4GFufCwjIftq1sBXNLA\nNaHMN4r2Z0Gmlw_TkR4zRg:xiF4r+qkooumshATV2Z5YQ\nySVXOgf9QhF2jpw2ptsDvA:HwMWCiaGSbZyBp_Ap9KUiA\nvKTKQRRT60StCD2WFo57DA:ez09BiQKyTqKAmyjIoCFvw\nj7ccUxzLbcB+duNxUlZukg:8r7JzBQcvuenPo6oBTwcvQ\nUQGcVripbUKy3WWej9XYkA:P9vXvhv62cB1IyQBA6VQ+g\n9NpfZNdDB5IVp3vG1HTafw:OI1UUEfEoh7WruyLAl9Vzw\nJN4XaBrOaUO0lJAZRIczzw:0u6aWVIh5SJcPEVBMVgTKw\nSnbFdKk_Yr4cusZGL0PbVw:UxywkpJH4yg1Y7v8nzWOsw\n00_KeiZHUlPL2TAbBAKT4A:ete1ifIh7qe3hIOWOectgg\nIBpHnpKnpUaNxlwOzUnwZA:XmkEJvlIGgzHyifJoYKhQQ\n2YCuqrXUrWhaUTY0YqmFDg:JFaz77i5eIs_6+wBEQ7tiw\nryxptVmioyYKEw_QWLeQpA:VA5Oo6sJ6OYQjlmt2gm50w\n0N1fxN+UvEywlV0xqy8aZw:B1qt30pbd8FE2DewInsfoA\nGPnHxFoo40ivsAMtV+AdLQ:00vmqqxNLqP42ZjKX6xTCw\nI+u+z3kxH0eZPzYwSqtzbA:YiSN1_wZ0j+tKH_5PmIlFw\nuM9o1gr9_0CeweEriVJKWQ:aVvQ02BsIJkwopxbA4Tp6g\nupnl6u8f6Gj22hJWH9tzQQ:gsPKKsypftma2Hgj9v9Mjw");
			RunningInfo.InvokeRegister(tran, "ssHunspell._RunningInfo, Hunspell");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "Hunspell", "vMh7EXtFGEmFMNadlkrhMA:_nsZKSsHJzLGw+p7TDxWqw");
			RunningInfo.InvokeRegister(tran, "ssBaseTheme._RunningInfo, BaseTheme");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "BaseTheme", "9KTY1+dySkmEnm_cwvfIWA:UWBm2v0gRK6GRqeeWLctHw");
			RunningInfo.InvokeRegister(tran, "ssCommonFunctions._RunningInfo, CommonFunctions");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "CommonFunctions", "DyUWATlJPkikRJKOsbbNaQ:V3NO8bufveLs+TDLScxkbQ\ngF9qLigNBk+s5D8rhUQtWQ:WJK+5a4uXJKbkw30ixA3aw\nUhrNdWvxokiubKt715GbAQ:5nMBOb_6+O7NZryWT2jwQQ");
			RunningInfo.InvokeRegister(tran, "ssForSkillsConnector._RunningInfo, ForSkillsConnector");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "ForSkillsConnector", "AMaUBV28x02GuzkXrOm00w:ypwjBTJc5mS9ADVhjVVJqg\nXzmcVxRT8EK4yG42Qi5PEA:YbsnITh284n+_OZGscFKyg\nMNoKtjiiSkm0v_BmHf3S1Q:yKvSmQgwjm6cafVrqSPP6A");
			RunningInfo.InvokeRegister(tran, "ssSilkUIFramework._RunningInfo, SilkUIFramework");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "SilkUIFramework", "6_cFL++D20OOcIitphJaTg:wlSizUE+cTzhA87QBoVJaQ\nyXckVV_k30GLPBxzdlTqHw:IVunn7slxwYS50erd5hhvQ");
			RunningInfo.InvokeRegister(tran, "ssCaseConferencingCore._RunningInfo, CaseConferencingCore");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "CaseConferencingCore", "22amAd0EHkm0xk+X_m5Jhg:6OE69iI5gNGj_v1wDC9FYA\npt+OA7qY8UOgqxLxNxMqyg:k_4FNkoRBRFxcFU9n2F9YQ\nWgg_Cis7YEWfSLrtd+IWkw:mQmEP_XNOTaBY3ohKU5WTg\nvCuPF0yzWE2TkstQFsCAag:ywNhqoPgPcB7BGTvlqtCdg\nOr+WF_oBVEiDT9wsVlLJPg:LeUdP4nBPkQxP0Mt+oLmdw\nlG3hF0hzWkKoeGY9omlHxg:Onhzl02AoDZOSlmskZNrpA\nnUSTGlRQZ0WtOpBvpD8AmA:eZx1QFzcTTPlVpN4UXxhCw\nO+Y2HP0aEUqdLmXGbT3jhw:3YegKuM9SEW8C7S9vKMb4A\nIha9HEOM20+ODr+Fv9xrdg:1mj1Gj79Og75O+pQaQAiMg\nOPdBI7UGuECilQnyvs1v5w:aZKyu8mLA8PPeL0iAlo3yg\nWFJvKK3kqUeCVuiOOnsqxg:_uoDQGciX0hjeB41Avn4AQ\nRLN2KYw5JEGLdH9ILlt6+g:DlJOHnRhWnAVXDq91EpOIQ\nln9NK_ZWS0K3w4rcqhdxaA:6chD4WJPmb2iiKejijI0EQ\nZFfsLe7GZUGGfxInNs2jCw:2drWCGmMbDooxV11Y6mQpA\nl5pOL5vpbUaP5MfrqtxbRw:LrjjfmoANtt6YjBeETNPbg\n3GKcNEwJyEyA8lBnqOFjYA:jJgkY1cbrYvuA3eMZFgKxw\nQA_tNWfHfkC0v74rVzXvNg:oZdvBD8qDrf8r93GM2jifg\nQPKhNsbIb0WsrtdpnK6TqQ:TuTVNU7R+vvkK732Zj8QLg\njGRPPM+EVk6UZVWjLmeLqg:AKZceDFeL4saO2uaCJMVag\nfzDrPRolI0KIIhJsdqJYTw:OQVyvnjTsz01_VWyNVSxoA\nNhT+QgL3QUePWIfuYnK55w:laqNbFDwugzI9jtYQNpXIQ\nQDRBRPG73UW70+_ruBTnHQ:hGP5qAM5IoxVGK+t_0lJIw\n_NpVS1NMfkKnHxUXpt6s1g:UFSiBblm42iyoBs9hfzTwg\n1hJPUjBcq0CFLmHpZFjmHA:z886MvcUJ3ffmHhz54OU8w\n+363Vp5+VUW78zA6hSSlLA:sYqDbWPXgIF3xY_+X5h7ZQ\nqfFKV4uQjEqP+yf0HBKX_Q:DMwGa9ly3uxaWeRGrr_QXg\nm0_1VyaTyUOIlUjXDuh5Dg:v5JMBgasNg9prClZCSUGeg\nllUpWWCP3U+d663aYkoljg:k4ixMYKaoepfiV4m+HrS3g\n+pCxYtjo0EiZNVrlXqwksg:D6IF9lszKRMaiwgB5CGLlw\nBblLZpiz_UGneFNeor32rw:IfctxqBOniGv" +
			"0RKx5+Gp9Q\nhyLActzq3Eeh8rk_byzwNw:U4Un76wE7n9ce0Mj_BX7Dw\nBdfRdDFpZUidjZ3VE_8XoQ:HatQFiEtLPrert_edEoBlA\niLzfdW3Lr0Ctc22hXvN8eQ:OQto8pa0fcQ87dADj5mQOQ\nAMEYdoUDH0yDDl_GoRN3wg:HpNqdGbzQZn7juZa7lElUQ\nsMjnfCpPp0SoF+3ldnpjkw:vEgnqlQeq104zpLnelGn_A\nHKRagA60EUamH5J6pX17yQ:r6hXrORSx0_o4e5IZtBozg\npUPUgWSqR0K4tFgOdlqmaA:cxc6MI_iOsNXrUTfkYbULw\n4aCBhQzxgUKgSyw5MsoULw:HOnhZBCl3BFyCpkODRhdqQ\n_uPQhpdVlkq5TX2DRiFKSg:z3tHi+XgPbvIKJ17+Je0EQ\nX9ZBibHrcEu_encyr28blA:w6v8h78Z4XpHKG2gqgxKag\ns1RcjLcoYkK2hmGSDEFTmg:dbX0ZQ8rgvmhVTY+q2k6OQ\nnmJxjKnVRECTUOMLDIfJHw:zjGRkyzduOS_sQltcHCmSQ\nNVVLkNOKwUO6bG_0+JGKvw:TQHVbDCSEBOa_bQXqLzPEw\ngbiMlLhO60yo5_46+MPiVA:L9ir+dX3Sg2p5E8w8LlJ+Q\nS5WQl+FCDkCgYNgWtvyDUQ:KD4FisTC_9Jkq8C9S4WIvA\nM22cncimFEuCLodZl4ERMw:krXyoVSxr9nRtDH1SAeQpw\nicmvn29MikCpfMrnJl0t+Q:OIeYRc_375y6CeE+ZxbMzQ\nm1nfoo+2fk+K7XgRUvh8cg:3LUgfaO9SdqyH2JjkZOobQ\n1XrqqDJYxE+9YhumwHzbhA:khH+2zs+okKQSsA4MH5vHw\nqoAsqRczLECwsD3+S+Zvrw:2AzRLAEM4DlD3tv4miM6rQ\nkfdIqjC2DEOiPdbWXpzj9Q:OLpF7JXlJeiJikyY7PN3PA\nxLOcsDiOM0WuRteF0ZvSnw:hUEFA7CN98CYOe43I9pdQg\n1AZdsWyDQ0m1e2vNAa__GA:ois8nv2PHoIyQ80bQlSQew\nNM+4sxee602n9aTPcNyy4A:z_sxTwNuyx+VuOMYaFvwsw\nUY2pt2KcvU6JsriMl6lBsA:ixRfiKof6wIZtyBN_X2M7w\n85Awve+eLUKAgZI+ZBm30A:bDT4nIcIGZ6lC8mfbI5kfQ\n9E3FvSiG2kqoIGN2MwdSrw:NbF1MN_Iya1X_4DHWLA1YQ\n0q6RwBgw40O9WF4jAurDJg:yDBVNXIPL3epmfHBmQ9Fzw\nTZ8ex_HQW0uPXse9Xj8mSA:v3ScT4CYAR6tRIxs_EmiFA\nr7ZqyW8WjUWwacABe8jCDg:B_gPTzBw7iJC+AD1fQjTwA\nHJUjzsIql0yCvE4gT_8AwQ:XusKSWgc8K0lUbH3UWqrHg\nQ4nS0YsImkGMnMFYwc" +
			"B8bQ:sOUDr078tbu4XZhSe8TbaA\n9aLF1LjADEOGegA22gIMGw:FD4tfEcAdUnmlr4xBy8zsw\nL4yT1SaTuEql8gWzNmOWjg:q6UmC5iETGNz+KdpbnwUzA\n5bHH1dChUECZlBJ9s4BRHg:_Lh6gRkuFDy0tGbSQuN5xg\n7F+m27z1ykq1YO41OxZOVQ:9HPm31y4jkQiOLZgYRv+kQ\nUAy_3Cv8ikeRIt3GXP0NPQ:fpfIsOC6_egFXDUB+DqIGg\npiUg3ZSGSECvmAeLVlx2+Q:TbLd_6RPnz4EzwpS4B9jug\nTRvp3vdUy0Oj0dFqv6+bdQ:QhhBl3ShsZIiwHhzqI6Ibw\nR14e4VafE0O4yQ7Ln70y7g:5w_gpPHx2zQKWQGo1Y7ZMA\n39Ir45xWg0q8U_gWlEhK2w:NCgCBQWR1Db2uFYTuPq04g\nwXuh5JUTE0GVx5s+xTNRRg:1EdCrgmLrAEezbgjtT5h0A\nff_q5uNgekiBlNaPFpW3Mw:R2gSI_+sngPHwo64IdPWJQ\nLhIW6SUQYE6dWkCv3qSIxQ:vh+5GueGpBQnsHokI2t5cA\nfB3E6o81tkSFlASoXr9oIA:ktRanuDYGFtQdZplKDyaGw\naO4n8nZXm0WfqYfrE+m7AA:MoItp0cImpYBM4ZUWdannw\nyzir9NuUGEO9NjjtX+Kexw:Fu7g7Rx_hnJ+g3BmnIrYaw\nvfiY+ak2p0qQJa3KtgcS4g:UkQA7x37pVcmboC0UEhscQ\npdes_lTUpEGdtyvGrseheA:_cwgX4LHJNacWlu0TLQTSQ");
			RunningInfo.InvokeRegister(tran, "ssTwilioCon._RunningInfo, TwilioCon");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "TwilioCon", "S__HzUeVRkKwjU1doQcwxw:SHIjhZfaeuTUVBBCAyq5kw");
			RunningInfo.InvokeRegister(tran, "ssProMonitorConnector._RunningInfo, ProMonitorConnector");
			RunningInfo.RegisterAssemblyDependency(tran, "CaseConferencing", "ProMonitorConnector", "+AmkARdCwUSV6Y1Ny46A0Q:gCkEWzAuywhRLENjKNJydQ\nBrVcMmdl7kib7Iq6kSRqlQ:_ZAsQ8yIzgpFVql1D8omOQ\nxrrhYzTr_km7W2Z1lbknBQ:0idRu+jKI7b3+t74lnoQlQ\n4sJh2m8jCU+uRwS35q+rfA:vx3k161PKXgYcnPmen7M9Q\nSzmp2moaAkKSqhVqzF1isg:vo8uxzq2XYWTzEQBdheBCg\nBX+C8HQmtkK+wytDmRKwsw:XTyI67P5paOFQM_fRmceDQ");

		}
	}
}