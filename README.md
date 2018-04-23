# HisMicroserviceSample
This is a sample of HIS,it is microservice architecture.

### 项目说明
1. API网关	  OcelotGatewayService	         6800	    API网关
2. 基础服务	  BasicService	                 6801	    微服务的基础资料管理
3. 进销存服务 InvoicingService	              6802	   负责药房药局的数据信息管理
4. 门诊服务   OutpatientService	             6803	    门诊业务管理
5. 住院服务	  InpatientService	             6804	    住院业务管理
6. 结算服务	  SettlementService	             6805	    门诊，住院结算管理
7. 认证服务	  AuthenticationService	         6806	    负责用户认证，通过返回token
8. 后台服务 	BackgroundService	             6810	    负责后端的计划和后台任务

### 课程
课程链接：http://edu.51cto.com/course/13342.html
《基于.net core微服务架构》：consul服务治理，ocelot API网关，JWTAuthgorizePolicy统一验证，Docker布署，App.Metrics运维监控，Exceptionless分布式日志，MassTransit+MQ基于补偿机制数据一致性，Jenkins持续化集成，Polly,Refit三方库；

#### 课程说明：
1. 第一节	微服务概述	介绍微服务的基本概念，特点，以及一些微服务框架：Spring Cloud,k8s,Service Fabric
2. 第二节	Consul服务治理	Consul作为服务治理的框架，本课讲解Consul的基本命令，配置文件，以及如何搭建运行一个Consul集群
3. 第三节	Ocelot API网关  Ocelot是基于.net core的API网关，本课讲解Ocelot的基本配置，以及如何与Consul联合命名用，实现服务治理，负载均衡，限流，熔断等功能
4. 第四节	统一验证	讲解自定义基于JWT的网关统一验证API,
5. 第五节	Docker布署asp.net core	讲解docker基本概念，基础命令，以及如何发布一个asp.net core到docker中。
6. 第六节	App.Metrics监控	Ocelot API网关项目中使用App.Metrics写入性能监控数据，用InfluxDB作为时序数据库存储，用Grafana作为性能监控UI来获取并展示数据
7. 第七节	Exceptionless分布式日志	介绍Exceptionless安装，配置，以及在asp.net core中的使用。
8. 第八节	数据一致性（上）	讲解数据一致性的理论，介绍MassTransit的基本使用性况，Quartz.NET的使用。
	数据一致性（下）用补偿机制实例讲解最终数据一致性的asp.net core项目实现
9. 第九节	Jenkins	介绍Jenkins配置，批处理编排实现asp.net core应用的自动化Docker布署
10. 第十节	.net core三方库	主要介绍Polly和Refit的使用，为微服务客户端提供访问技术，然后概述一些常见的三方.net core库

