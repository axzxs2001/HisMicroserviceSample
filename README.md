# HisMicroserviceSample
This is a sample of HIS,it is microservice architecture.

### 项目说明
1. API网关	   OcelotGatewayService	         6800	    API网关
2. 基础服务	 BasicService	                 6801	    微服务的基础资料管理
3. 进销存服务	InvoicingService	            6802	   负责药房药局的数据信息管理
4. 门诊服务   OutpatientService	           6803	    门诊业务管理
5. 住院服务	 InpatientService	             6804	    住院业务管理
6. 结算服务	 SettlementService	           6805	    门诊，住院结算管理
7. 认证服务	 AuthenticationService	       6806	    负责用户认证，通过返回token
