/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tem.V20210701
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tem.V20210701.Models;

   public class TemClient : AbstractClient{

       private const string endpoint = "tem.tencentcloudapi.com";
       private const string version = "2021-07-01";
       private const string sdkVersion = "SDK_NET_3.0.862";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TemClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TemClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public Task<CreateApplicationResponse> CreateApplication(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication");
        }

        /// <summary>
        /// This API is used to create an application.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationRequest"/></param>
        /// <returns><see cref="CreateApplicationResponse"/></returns>
        public CreateApplicationResponse CreateApplicationSync(CreateApplicationRequest req)
        {
            return InternalRequestAsync<CreateApplicationResponse>(req, "CreateApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="CreateApplicationAutoscalerResponse"/></returns>
        public Task<CreateApplicationAutoscalerResponse> CreateApplicationAutoscaler(CreateApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<CreateApplicationAutoscalerResponse>(req, "CreateApplicationAutoscaler");
        }

        /// <summary>
        /// This API is used to create a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="CreateApplicationAutoscalerResponse"/></returns>
        public CreateApplicationAutoscalerResponse CreateApplicationAutoscalerSync(CreateApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<CreateApplicationAutoscalerResponse>(req, "CreateApplicationAutoscaler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an access policy. 
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationServiceRequest"/></param>
        /// <returns><see cref="CreateApplicationServiceResponse"/></returns>
        public Task<CreateApplicationServiceResponse> CreateApplicationService(CreateApplicationServiceRequest req)
        {
            return InternalRequestAsync<CreateApplicationServiceResponse>(req, "CreateApplicationService");
        }

        /// <summary>
        /// This API is used to create an access policy. 
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationServiceRequest"/></param>
        /// <returns><see cref="CreateApplicationServiceResponse"/></returns>
        public CreateApplicationServiceResponse CreateApplicationServiceSync(CreateApplicationServiceRequest req)
        {
            return InternalRequestAsync<CreateApplicationServiceResponse>(req, "CreateApplicationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigDataRequest"/></param>
        /// <returns><see cref="CreateConfigDataResponse"/></returns>
        public Task<CreateConfigDataResponse> CreateConfigData(CreateConfigDataRequest req)
        {
            return InternalRequestAsync<CreateConfigDataResponse>(req, "CreateConfigData");
        }

        /// <summary>
        /// This API is used to create a configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateConfigDataRequest"/></param>
        /// <returns><see cref="CreateConfigDataResponse"/></returns>
        public CreateConfigDataResponse CreateConfigDataSync(CreateConfigDataRequest req)
        {
            return InternalRequestAsync<CreateConfigDataResponse>(req, "CreateConfigData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate a COS temporary key.
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenRequest"/></param>
        /// <returns><see cref="CreateCosTokenResponse"/></returns>
        public Task<CreateCosTokenResponse> CreateCosToken(CreateCosTokenRequest req)
        {
            return InternalRequestAsync<CreateCosTokenResponse>(req, "CreateCosToken");
        }

        /// <summary>
        /// This API is used to generate a COS temporary key.
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenRequest"/></param>
        /// <returns><see cref="CreateCosTokenResponse"/></returns>
        public CreateCosTokenResponse CreateCosTokenSync(CreateCosTokenRequest req)
        {
            return InternalRequestAsync<CreateCosTokenResponse>(req, "CreateCosToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an environment.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public Task<CreateEnvironmentResponse> CreateEnvironment(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment");
        }

        /// <summary>
        /// This API is used to create an environment.
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public CreateEnvironmentResponse CreateEnvironmentSync(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateLogConfigRequest"/></param>
        /// <returns><see cref="CreateLogConfigResponse"/></returns>
        public Task<CreateLogConfigResponse> CreateLogConfig(CreateLogConfigRequest req)
        {
            return InternalRequestAsync<CreateLogConfigResponse>(req, "CreateLogConfig");
        }

        /// <summary>
        /// This API is used to create a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateLogConfigRequest"/></param>
        /// <returns><see cref="CreateLogConfigResponse"/></returns>
        public CreateLogConfigResponse CreateLogConfigSync(CreateLogConfigRequest req)
        {
            return InternalRequestAsync<CreateLogConfigResponse>(req, "CreateLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a cloud resource.
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public Task<CreateResourceResponse> CreateResource(CreateResourceRequest req)
        {
            return InternalRequestAsync<CreateResourceResponse>(req, "CreateResource");
        }

        /// <summary>
        /// This API is used to bind a cloud resource.
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public CreateResourceResponse CreateResourceSync(CreateResourceRequest req)
        {
            return InternalRequestAsync<CreateResourceResponse>(req, "CreateResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an application.
        ///   - Stop running the current application
        ///   - Delete resources related to the application
        ///   - Delete the application
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public Task<DeleteApplicationResponse> DeleteApplication(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication");
        }

        /// <summary>
        /// This API is used to delete an application.
        ///   - Stop running the current application
        ///   - Delete resources related to the application
        ///   - Delete the application
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public DeleteApplicationResponse DeleteApplicationSync(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DeleteApplicationAutoscalerResponse"/></returns>
        public Task<DeleteApplicationAutoscalerResponse> DeleteApplicationAutoscaler(DeleteApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<DeleteApplicationAutoscalerResponse>(req, "DeleteApplicationAutoscaler");
        }

        /// <summary>
        /// This API is used to delete a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DeleteApplicationAutoscalerResponse"/></returns>
        public DeleteApplicationAutoscalerResponse DeleteApplicationAutoscalerSync(DeleteApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<DeleteApplicationAutoscalerResponse>(req, "DeleteApplicationAutoscaler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an access policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationServiceRequest"/></param>
        /// <returns><see cref="DeleteApplicationServiceResponse"/></returns>
        public Task<DeleteApplicationServiceResponse> DeleteApplicationService(DeleteApplicationServiceRequest req)
        {
            return InternalRequestAsync<DeleteApplicationServiceResponse>(req, "DeleteApplicationService");
        }

        /// <summary>
        /// This API is used to delete an access policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationServiceRequest"/></param>
        /// <returns><see cref="DeleteApplicationServiceResponse"/></returns>
        public DeleteApplicationServiceResponse DeleteApplicationServiceSync(DeleteApplicationServiceRequest req)
        {
            return InternalRequestAsync<DeleteApplicationServiceResponse>(req, "DeleteApplicationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteIngressRequest"/></param>
        /// <returns><see cref="DeleteIngressResponse"/></returns>
        public Task<DeleteIngressResponse> DeleteIngress(DeleteIngressRequest req)
        {
            return InternalRequestAsync<DeleteIngressResponse>(req, "DeleteIngress");
        }

        /// <summary>
        /// This API is used to delete an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteIngressRequest"/></param>
        /// <returns><see cref="DeleteIngressResponse"/></returns>
        public DeleteIngressResponse DeleteIngressSync(DeleteIngressRequest req)
        {
            return InternalRequestAsync<DeleteIngressResponse>(req, "DeleteIngress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to deploy an application.
        /// </summary>
        /// <param name="req"><see cref="DeployApplicationRequest"/></param>
        /// <returns><see cref="DeployApplicationResponse"/></returns>
        public Task<DeployApplicationResponse> DeployApplication(DeployApplicationRequest req)
        {
            return InternalRequestAsync<DeployApplicationResponse>(req, "DeployApplication");
        }

        /// <summary>
        /// This API is used to deploy an application.
        /// </summary>
        /// <param name="req"><see cref="DeployApplicationRequest"/></param>
        /// <returns><see cref="DeployApplicationResponse"/></returns>
        public DeployApplicationResponse DeployApplicationSync(DeployApplicationRequest req)
        {
            return InternalRequestAsync<DeployApplicationResponse>(req, "DeployApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the scaling rules of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationAutoscalerListRequest"/></param>
        /// <returns><see cref="DescribeApplicationAutoscalerListResponse"/></returns>
        public Task<DescribeApplicationAutoscalerListResponse> DescribeApplicationAutoscalerList(DescribeApplicationAutoscalerListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationAutoscalerListResponse>(req, "DescribeApplicationAutoscalerList");
        }

        /// <summary>
        /// This API is used to query the scaling rules of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationAutoscalerListRequest"/></param>
        /// <returns><see cref="DescribeApplicationAutoscalerListResponse"/></returns>
        public DescribeApplicationAutoscalerListResponse DescribeApplicationAutoscalerListSync(DescribeApplicationAutoscalerListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationAutoscalerListResponse>(req, "DescribeApplicationAutoscalerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the basic information of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfoRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfoResponse"/></returns>
        public Task<DescribeApplicationInfoResponse> DescribeApplicationInfo(DescribeApplicationInfoRequest req)
        {
            return InternalRequestAsync<DescribeApplicationInfoResponse>(req, "DescribeApplicationInfo");
        }

        /// <summary>
        /// This API is used to check the basic information of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationInfoRequest"/></param>
        /// <returns><see cref="DescribeApplicationInfoResponse"/></returns>
        public DescribeApplicationInfoResponse DescribeApplicationInfoSync(DescribeApplicationInfoRequest req)
        {
            return InternalRequestAsync<DescribeApplicationInfoResponse>(req, "DescribeApplicationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of application pods.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationPodsRequest"/></param>
        /// <returns><see cref="DescribeApplicationPodsResponse"/></returns>
        public Task<DescribeApplicationPodsResponse> DescribeApplicationPods(DescribeApplicationPodsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationPodsResponse>(req, "DescribeApplicationPods");
        }

        /// <summary>
        /// This API is used to get the list of application pods.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationPodsRequest"/></param>
        /// <returns><see cref="DescribeApplicationPodsResponse"/></returns>
        public DescribeApplicationPodsResponse DescribeApplicationPodsSync(DescribeApplicationPodsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationPodsResponse>(req, "DescribeApplicationPods")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of access policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationServiceListRequest"/></param>
        /// <returns><see cref="DescribeApplicationServiceListResponse"/></returns>
        public Task<DescribeApplicationServiceListResponse> DescribeApplicationServiceList(DescribeApplicationServiceListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationServiceListResponse>(req, "DescribeApplicationServiceList");
        }

        /// <summary>
        /// This API is used to query the list of access policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationServiceListRequest"/></param>
        /// <returns><see cref="DescribeApplicationServiceListResponse"/></returns>
        public DescribeApplicationServiceListResponse DescribeApplicationServiceListSync(DescribeApplicationServiceListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationServiceListResponse>(req, "DescribeApplicationServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is to query the list of running applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications");
        }

        /// <summary>
        /// This API is to query the list of running applications.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public DescribeApplicationsResponse DescribeApplicationsSync(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of all applications in an envrionment.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsStatusRequest"/></param>
        /// <returns><see cref="DescribeApplicationsStatusResponse"/></returns>
        public Task<DescribeApplicationsStatusResponse> DescribeApplicationsStatus(DescribeApplicationsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsStatusResponse>(req, "DescribeApplicationsStatus");
        }

        /// <summary>
        /// This API is used to query the status of all applications in an envrionment.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsStatusRequest"/></param>
        /// <returns><see cref="DescribeApplicationsStatusResponse"/></returns>
        public DescribeApplicationsStatusResponse DescribeApplicationsStatusSync(DescribeApplicationsStatusRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsStatusResponse>(req, "DescribeApplicationsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of a configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataRequest"/></param>
        /// <returns><see cref="DescribeConfigDataResponse"/></returns>
        public Task<DescribeConfigDataResponse> DescribeConfigData(DescribeConfigDataRequest req)
        {
            return InternalRequestAsync<DescribeConfigDataResponse>(req, "DescribeConfigData");
        }

        /// <summary>
        /// This API is used to query details of a configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataRequest"/></param>
        /// <returns><see cref="DescribeConfigDataResponse"/></returns>
        public DescribeConfigDataResponse DescribeConfigDataSync(DescribeConfigDataRequest req)
        {
            return InternalRequestAsync<DescribeConfigDataResponse>(req, "DescribeConfigData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataListRequest"/></param>
        /// <returns><see cref="DescribeConfigDataListResponse"/></returns>
        public Task<DescribeConfigDataListResponse> DescribeConfigDataList(DescribeConfigDataListRequest req)
        {
            return InternalRequestAsync<DescribeConfigDataListResponse>(req, "DescribeConfigDataList");
        }

        /// <summary>
        /// This API is used to query the list of configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDataListRequest"/></param>
        /// <returns><see cref="DescribeConfigDataListResponse"/></returns>
        public DescribeConfigDataListResponse DescribeConfigDataListSync(DescribeConfigDataListRequest req)
        {
            return InternalRequestAsync<DescribeConfigDataListResponse>(req, "DescribeConfigDataList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the basic information of an environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentResponse"/></returns>
        public Task<DescribeEnvironmentResponse> DescribeEnvironment(DescribeEnvironmentRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentResponse>(req, "DescribeEnvironment");
        }

        /// <summary>
        /// This API is used to obtain the basic information of an environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentResponse"/></returns>
        public DescribeEnvironmentResponse DescribeEnvironmentSync(DescribeEnvironmentRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentResponse>(req, "DescribeEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the environment status.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentStatusRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentStatusResponse"/></returns>
        public Task<DescribeEnvironmentStatusResponse> DescribeEnvironmentStatus(DescribeEnvironmentStatusRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentStatusResponse>(req, "DescribeEnvironmentStatus");
        }

        /// <summary>
        /// This API is used to obtain the environment status.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentStatusRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentStatusResponse"/></returns>
        public DescribeEnvironmentStatusResponse DescribeEnvironmentStatusSync(DescribeEnvironmentStatusRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentStatusResponse>(req, "DescribeEnvironmentStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of environments. 
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// This API is used to obtain the list of environments. 
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressRequest"/></param>
        /// <returns><see cref="DescribeIngressResponse"/></returns>
        public Task<DescribeIngressResponse> DescribeIngress(DescribeIngressRequest req)
        {
            return InternalRequestAsync<DescribeIngressResponse>(req, "DescribeIngress");
        }

        /// <summary>
        /// This API is used to query an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressRequest"/></param>
        /// <returns><see cref="DescribeIngressResponse"/></returns>
        public DescribeIngressResponse DescribeIngressSync(DescribeIngressRequest req)
        {
            return InternalRequestAsync<DescribeIngressResponse>(req, "DescribeIngress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of ingress rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressesRequest"/></param>
        /// <returns><see cref="DescribeIngressesResponse"/></returns>
        public Task<DescribeIngressesResponse> DescribeIngresses(DescribeIngressesRequest req)
        {
            return InternalRequestAsync<DescribeIngressesResponse>(req, "DescribeIngresses");
        }

        /// <summary>
        /// This API is used to query the list of ingress rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeIngressesRequest"/></param>
        /// <returns><see cref="DescribeIngressesResponse"/></returns>
        public DescribeIngressesResponse DescribeIngressesSync(DescribeIngressesRequest req)
        {
            return InternalRequestAsync<DescribeIngressesResponse>(req, "DescribeIngresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query details of a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogConfigRequest"/></param>
        /// <returns><see cref="DescribeLogConfigResponse"/></returns>
        public Task<DescribeLogConfigResponse> DescribeLogConfig(DescribeLogConfigRequest req)
        {
            return InternalRequestAsync<DescribeLogConfigResponse>(req, "DescribeLogConfig");
        }

        /// <summary>
        /// This API is used to query details of a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogConfigRequest"/></param>
        /// <returns><see cref="DescribeLogConfigResponse"/></returns>
        public DescribeLogConfigResponse DescribeLogConfigSync(DescribeLogConfigRequest req)
        {
            return InternalRequestAsync<DescribeLogConfigResponse>(req, "DescribeLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to querying the list of log collecting configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribePagedLogConfigListRequest"/></param>
        /// <returns><see cref="DescribePagedLogConfigListResponse"/></returns>
        public Task<DescribePagedLogConfigListResponse> DescribePagedLogConfigList(DescribePagedLogConfigListRequest req)
        {
            return InternalRequestAsync<DescribePagedLogConfigListResponse>(req, "DescribePagedLogConfigList");
        }

        /// <summary>
        /// This API is used to querying the list of log collecting configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribePagedLogConfigListRequest"/></param>
        /// <returns><see cref="DescribePagedLogConfigListResponse"/></returns>
        public DescribePagedLogConfigListResponse DescribePagedLogConfigListSync(DescribePagedLogConfigListRequest req)
        {
            return InternalRequestAsync<DescribePagedLogConfigListResponse>(req, "DescribePagedLogConfigList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of ingress rules associated with the application.
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedIngressesRequest"/></param>
        /// <returns><see cref="DescribeRelatedIngressesResponse"/></returns>
        public Task<DescribeRelatedIngressesResponse> DescribeRelatedIngresses(DescribeRelatedIngressesRequest req)
        {
            return InternalRequestAsync<DescribeRelatedIngressesResponse>(req, "DescribeRelatedIngresses");
        }

        /// <summary>
        /// This API is used to query the list of ingress rules associated with the application.
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedIngressesRequest"/></param>
        /// <returns><see cref="DescribeRelatedIngressesResponse"/></returns>
        public DescribeRelatedIngressesResponse DescribeRelatedIngressesSync(DescribeRelatedIngressesRequest req)
        {
            return InternalRequestAsync<DescribeRelatedIngressesResponse>(req, "DescribeRelatedIngresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a configuration.
        /// </summary>
        /// <param name="req"><see cref="DestroyConfigDataRequest"/></param>
        /// <returns><see cref="DestroyConfigDataResponse"/></returns>
        public Task<DestroyConfigDataResponse> DestroyConfigData(DestroyConfigDataRequest req)
        {
            return InternalRequestAsync<DestroyConfigDataResponse>(req, "DestroyConfigData");
        }

        /// <summary>
        /// This API is used to terminate a configuration.
        /// </summary>
        /// <param name="req"><see cref="DestroyConfigDataRequest"/></param>
        /// <returns><see cref="DestroyConfigDataResponse"/></returns>
        public DestroyConfigDataResponse DestroyConfigDataSync(DestroyConfigDataRequest req)
        {
            return InternalRequestAsync<DestroyConfigDataResponse>(req, "DestroyConfigData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate an environment.
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvironmentRequest"/></param>
        /// <returns><see cref="DestroyEnvironmentResponse"/></returns>
        public Task<DestroyEnvironmentResponse> DestroyEnvironment(DestroyEnvironmentRequest req)
        {
            return InternalRequestAsync<DestroyEnvironmentResponse>(req, "DestroyEnvironment");
        }

        /// <summary>
        /// This API is used to terminate an environment.
        /// </summary>
        /// <param name="req"><see cref="DestroyEnvironmentRequest"/></param>
        /// <returns><see cref="DestroyEnvironmentResponse"/></returns>
        public DestroyEnvironmentResponse DestroyEnvironmentSync(DestroyEnvironmentRequest req)
        {
            return InternalRequestAsync<DestroyEnvironmentResponse>(req, "DestroyEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="DestroyLogConfigRequest"/></param>
        /// <returns><see cref="DestroyLogConfigResponse"/></returns>
        public Task<DestroyLogConfigResponse> DestroyLogConfig(DestroyLogConfigRequest req)
        {
            return InternalRequestAsync<DestroyLogConfigResponse>(req, "DestroyLogConfig");
        }

        /// <summary>
        /// This API is used to terminate a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="DestroyLogConfigRequest"/></param>
        /// <returns><see cref="DestroyLogConfigResponse"/></returns>
        public DestroyLogConfigResponse DestroyLogConfigSync(DestroyLogConfigRequest req)
        {
            return InternalRequestAsync<DestroyLogConfigResponse>(req, "DestroyLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="DisableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DisableApplicationAutoscalerResponse"/></returns>
        public Task<DisableApplicationAutoscalerResponse> DisableApplicationAutoscaler(DisableApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<DisableApplicationAutoscalerResponse>(req, "DisableApplicationAutoscaler");
        }

        /// <summary>
        /// This API is used to disable a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="DisableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="DisableApplicationAutoscalerResponse"/></returns>
        public DisableApplicationAutoscalerResponse DisableApplicationAutoscalerSync(DisableApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<DisableApplicationAutoscalerResponse>(req, "DisableApplicationAutoscaler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="EnableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="EnableApplicationAutoscalerResponse"/></returns>
        public Task<EnableApplicationAutoscalerResponse> EnableApplicationAutoscaler(EnableApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<EnableApplicationAutoscalerResponse>(req, "EnableApplicationAutoscaler");
        }

        /// <summary>
        /// This API is used to enable a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="EnableApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="EnableApplicationAutoscalerResponse"/></returns>
        public EnableApplicationAutoscalerResponse EnableApplicationAutoscalerSync(EnableApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<EnableApplicationAutoscalerResponse>(req, "EnableApplicationAutoscaler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate the pre-signed download URL for the specified application package.
        /// </summary>
        /// <param name="req"><see cref="GenerateApplicationPackageDownloadUrlRequest"/></param>
        /// <returns><see cref="GenerateApplicationPackageDownloadUrlResponse"/></returns>
        public Task<GenerateApplicationPackageDownloadUrlResponse> GenerateApplicationPackageDownloadUrl(GenerateApplicationPackageDownloadUrlRequest req)
        {
            return InternalRequestAsync<GenerateApplicationPackageDownloadUrlResponse>(req, "GenerateApplicationPackageDownloadUrl");
        }

        /// <summary>
        /// This API is used to generate the pre-signed download URL for the specified application package.
        /// </summary>
        /// <param name="req"><see cref="GenerateApplicationPackageDownloadUrlRequest"/></param>
        /// <returns><see cref="GenerateApplicationPackageDownloadUrlResponse"/></returns>
        public GenerateApplicationPackageDownloadUrlResponse GenerateApplicationPackageDownloadUrlSync(GenerateApplicationPackageDownloadUrlRequest req)
        {
            return InternalRequestAsync<GenerateApplicationPackageDownloadUrlResponse>(req, "GenerateApplicationPackageDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="ModifyApplicationAutoscalerResponse"/></returns>
        public Task<ModifyApplicationAutoscalerResponse> ModifyApplicationAutoscaler(ModifyApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<ModifyApplicationAutoscalerResponse>(req, "ModifyApplicationAutoscaler");
        }

        /// <summary>
        /// This API is used to modify a scaling rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationAutoscalerRequest"/></param>
        /// <returns><see cref="ModifyApplicationAutoscalerResponse"/></returns>
        public ModifyApplicationAutoscalerResponse ModifyApplicationAutoscalerSync(ModifyApplicationAutoscalerRequest req)
        {
            return InternalRequestAsync<ModifyApplicationAutoscalerResponse>(req, "ModifyApplicationAutoscaler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the basic information of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationInfoResponse"/></returns>
        public Task<ModifyApplicationInfoResponse> ModifyApplicationInfo(ModifyApplicationInfoRequest req)
        {
            return InternalRequestAsync<ModifyApplicationInfoResponse>(req, "ModifyApplicationInfo");
        }

        /// <summary>
        /// This API is used to modify the basic information of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationInfoResponse"/></returns>
        public ModifyApplicationInfoResponse ModifyApplicationInfoSync(ModifyApplicationInfoRequest req)
        {
            return InternalRequestAsync<ModifyApplicationInfoResponse>(req, "ModifyApplicationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an access policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationServiceRequest"/></param>
        /// <returns><see cref="ModifyApplicationServiceResponse"/></returns>
        public Task<ModifyApplicationServiceResponse> ModifyApplicationService(ModifyApplicationServiceRequest req)
        {
            return InternalRequestAsync<ModifyApplicationServiceResponse>(req, "ModifyApplicationService");
        }

        /// <summary>
        /// This API is used to modify an access policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationServiceRequest"/></param>
        /// <returns><see cref="ModifyApplicationServiceResponse"/></returns>
        public ModifyApplicationServiceResponse ModifyApplicationServiceSync(ModifyApplicationServiceRequest req)
        {
            return InternalRequestAsync<ModifyApplicationServiceResponse>(req, "ModifyApplicationService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigDataRequest"/></param>
        /// <returns><see cref="ModifyConfigDataResponse"/></returns>
        public Task<ModifyConfigDataResponse> ModifyConfigData(ModifyConfigDataRequest req)
        {
            return InternalRequestAsync<ModifyConfigDataResponse>(req, "ModifyConfigData");
        }

        /// <summary>
        /// This API is used to modify a configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigDataRequest"/></param>
        /// <returns><see cref="ModifyConfigDataResponse"/></returns>
        public ModifyConfigDataResponse ModifyConfigDataSync(ModifyConfigDataRequest req)
        {
            return InternalRequestAsync<ModifyConfigDataResponse>(req, "ModifyConfigData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit an environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentResponse"/></returns>
        public Task<ModifyEnvironmentResponse> ModifyEnvironment(ModifyEnvironmentRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentResponse>(req, "ModifyEnvironment");
        }

        /// <summary>
        /// This API is used to edit an environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvironmentRequest"/></param>
        /// <returns><see cref="ModifyEnvironmentResponse"/></returns>
        public ModifyEnvironmentResponse ModifyEnvironmentSync(ModifyEnvironmentRequest req)
        {
            return InternalRequestAsync<ModifyEnvironmentResponse>(req, "ModifyEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create or update an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyIngressRequest"/></param>
        /// <returns><see cref="ModifyIngressResponse"/></returns>
        public Task<ModifyIngressResponse> ModifyIngress(ModifyIngressRequest req)
        {
            return InternalRequestAsync<ModifyIngressResponse>(req, "ModifyIngress");
        }

        /// <summary>
        /// This API is used to create or update an ingress rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyIngressRequest"/></param>
        /// <returns><see cref="ModifyIngressResponse"/></returns>
        public ModifyIngressResponse ModifyIngressSync(ModifyIngressRequest req)
        {
            return InternalRequestAsync<ModifyIngressResponse>(req, "ModifyIngress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogConfigRequest"/></param>
        /// <returns><see cref="ModifyLogConfigResponse"/></returns>
        public Task<ModifyLogConfigResponse> ModifyLogConfig(ModifyLogConfigRequest req)
        {
            return InternalRequestAsync<ModifyLogConfigResponse>(req, "ModifyLogConfig");
        }

        /// <summary>
        /// This API is used to modify a log collecting configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyLogConfigRequest"/></param>
        /// <returns><see cref="ModifyLogConfigResponse"/></returns>
        public ModifyLogConfigResponse ModifyLogConfigSync(ModifyLogConfigRequest req)
        {
            return InternalRequestAsync<ModifyLogConfigResponse>(req, "ModifyLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart an application.
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationRequest"/></param>
        /// <returns><see cref="RestartApplicationResponse"/></returns>
        public Task<RestartApplicationResponse> RestartApplication(RestartApplicationRequest req)
        {
            return InternalRequestAsync<RestartApplicationResponse>(req, "RestartApplication");
        }

        /// <summary>
        /// This API is used to restart an application.
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationRequest"/></param>
        /// <returns><see cref="RestartApplicationResponse"/></returns>
        public RestartApplicationResponse RestartApplicationSync(RestartApplicationRequest req)
        {
            return InternalRequestAsync<RestartApplicationResponse>(req, "RestartApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart an application pod.
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationPodRequest"/></param>
        /// <returns><see cref="RestartApplicationPodResponse"/></returns>
        public Task<RestartApplicationPodResponse> RestartApplicationPod(RestartApplicationPodRequest req)
        {
            return InternalRequestAsync<RestartApplicationPodResponse>(req, "RestartApplicationPod");
        }

        /// <summary>
        /// This API is used to restart an application pod.
        /// </summary>
        /// <param name="req"><see cref="RestartApplicationPodRequest"/></param>
        /// <returns><see cref="RestartApplicationPodResponse"/></returns>
        public RestartApplicationPodResponse RestartApplicationPodSync(RestartApplicationPodRequest req)
        {
            return InternalRequestAsync<RestartApplicationPodResponse>(req, "RestartApplicationPod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure the rolling update policy for an application.
        /// </summary>
        /// <param name="req"><see cref="RollingUpdateApplicationByVersionRequest"/></param>
        /// <returns><see cref="RollingUpdateApplicationByVersionResponse"/></returns>
        public Task<RollingUpdateApplicationByVersionResponse> RollingUpdateApplicationByVersion(RollingUpdateApplicationByVersionRequest req)
        {
            return InternalRequestAsync<RollingUpdateApplicationByVersionResponse>(req, "RollingUpdateApplicationByVersion");
        }

        /// <summary>
        /// This API is used to configure the rolling update policy for an application.
        /// </summary>
        /// <param name="req"><see cref="RollingUpdateApplicationByVersionRequest"/></param>
        /// <returns><see cref="RollingUpdateApplicationByVersionResponse"/></returns>
        public RollingUpdateApplicationByVersionResponse RollingUpdateApplicationByVersionSync(RollingUpdateApplicationByVersionRequest req)
        {
            return InternalRequestAsync<RollingUpdateApplicationByVersionResponse>(req, "RollingUpdateApplicationByVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop an application.
        /// </summary>
        /// <param name="req"><see cref="StopApplicationRequest"/></param>
        /// <returns><see cref="StopApplicationResponse"/></returns>
        public Task<StopApplicationResponse> StopApplication(StopApplicationRequest req)
        {
            return InternalRequestAsync<StopApplicationResponse>(req, "StopApplication");
        }

        /// <summary>
        /// This API is used to stop an application.
        /// </summary>
        /// <param name="req"><see cref="StopApplicationRequest"/></param>
        /// <returns><see cref="StopApplicationResponse"/></returns>
        public StopApplicationResponse StopApplicationSync(StopApplicationRequest req)
        {
            return InternalRequestAsync<StopApplicationResponse>(req, "StopApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
