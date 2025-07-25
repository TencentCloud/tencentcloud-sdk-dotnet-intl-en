/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Tem.V20201221
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tem.V20201221.Models;

   public class TemClient : AbstractClient{

       private const string endpoint = "tem.intl.tencentcloudapi.com";
       private const string version = "2020-12-21";
       private const string sdkVersion = "SDK_NET_3.0.1164";

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
        /// This API is used to generate a COS temporary key.
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenV2Request"/></param>
        /// <returns><see cref="CreateCosTokenV2Response"/></returns>
        public Task<CreateCosTokenV2Response> CreateCosTokenV2(CreateCosTokenV2Request req)
        {
            return InternalRequestAsync<CreateCosTokenV2Response>(req, "CreateCosTokenV2");
        }

        /// <summary>
        /// This API is used to generate a COS temporary key.
        /// </summary>
        /// <param name="req"><see cref="CreateCosTokenV2Request"/></param>
        /// <returns><see cref="CreateCosTokenV2Response"/></returns>
        public CreateCosTokenV2Response CreateCosTokenV2Sync(CreateCosTokenV2Request req)
        {
            return InternalRequestAsync<CreateCosTokenV2Response>(req, "CreateCosTokenV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an environment.
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace");
        }

        /// <summary>
        /// This API is used to create an environment.
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace")
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
        /// This API is used to create a service.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceV2Request"/></param>
        /// <returns><see cref="CreateServiceV2Response"/></returns>
        public Task<CreateServiceV2Response> CreateServiceV2(CreateServiceV2Request req)
        {
            return InternalRequestAsync<CreateServiceV2Response>(req, "CreateServiceV2");
        }

        /// <summary>
        /// This API is used to create a service.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceV2Request"/></param>
        /// <returns><see cref="CreateServiceV2Response"/></returns>
        public CreateServiceV2Response CreateServiceV2Sync(CreateServiceV2Request req)
        {
            return InternalRequestAsync<CreateServiceV2Response>(req, "CreateServiceV2")
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
        /// This API is used to deploy a service.
        /// </summary>
        /// <param name="req"><see cref="DeployServiceV2Request"/></param>
        /// <returns><see cref="DeployServiceV2Response"/></returns>
        public Task<DeployServiceV2Response> DeployServiceV2(DeployServiceV2Request req)
        {
            return InternalRequestAsync<DeployServiceV2Response>(req, "DeployServiceV2");
        }

        /// <summary>
        /// This API is used to deploy a service.
        /// </summary>
        /// <param name="req"><see cref="DeployServiceV2Request"/></param>
        /// <returns><see cref="DeployServiceV2Response"/></returns>
        public DeployServiceV2Response DeployServiceV2Sync(DeployServiceV2Request req)
        {
            return InternalRequestAsync<DeployServiceV2Response>(req, "DeployServiceV2")
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
        /// This API is used to get the list of tenant environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public Task<DescribeNamespacesResponse> DescribeNamespaces(DescribeNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeNamespacesResponse>(req, "DescribeNamespaces");
        }

        /// <summary>
        /// This API is used to get the list of tenant environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public DescribeNamespacesResponse DescribeNamespacesSync(DescribeNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeNamespacesResponse>(req, "DescribeNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of ingress rules associated with the service.
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedIngressesRequest"/></param>
        /// <returns><see cref="DescribeRelatedIngressesResponse"/></returns>
        public Task<DescribeRelatedIngressesResponse> DescribeRelatedIngresses(DescribeRelatedIngressesRequest req)
        {
            return InternalRequestAsync<DescribeRelatedIngressesResponse>(req, "DescribeRelatedIngresses");
        }

        /// <summary>
        /// This API is used to query the list of ingress rules associated with the service.
        /// </summary>
        /// <param name="req"><see cref="DescribeRelatedIngressesRequest"/></param>
        /// <returns><see cref="DescribeRelatedIngressesResponse"/></returns>
        public DescribeRelatedIngressesResponse DescribeRelatedIngressesSync(DescribeRelatedIngressesRequest req)
        {
            return InternalRequestAsync<DescribeRelatedIngressesResponse>(req, "DescribeRelatedIngresses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of running pods under a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRunPodListV2Request"/></param>
        /// <returns><see cref="DescribeServiceRunPodListV2Response"/></returns>
        public Task<DescribeServiceRunPodListV2Response> DescribeServiceRunPodListV2(DescribeServiceRunPodListV2Request req)
        {
            return InternalRequestAsync<DescribeServiceRunPodListV2Response>(req, "DescribeServiceRunPodListV2");
        }

        /// <summary>
        /// This API is used to get the list of running pods under a service.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceRunPodListV2Request"/></param>
        /// <returns><see cref="DescribeServiceRunPodListV2Response"/></returns>
        public DescribeServiceRunPodListV2Response DescribeServiceRunPodListV2Sync(DescribeServiceRunPodListV2Request req)
        {
            return InternalRequestAsync<DescribeServiceRunPodListV2Response>(req, "DescribeServiceRunPodListV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Generate the pre-signed download URL for the specified package
        /// </summary>
        /// <param name="req"><see cref="GenerateDownloadUrlRequest"/></param>
        /// <returns><see cref="GenerateDownloadUrlResponse"/></returns>
        public Task<GenerateDownloadUrlResponse> GenerateDownloadUrl(GenerateDownloadUrlRequest req)
        {
            return InternalRequestAsync<GenerateDownloadUrlResponse>(req, "GenerateDownloadUrl");
        }

        /// <summary>
        /// Generate the pre-signed download URL for the specified package
        /// </summary>
        /// <param name="req"><see cref="GenerateDownloadUrlRequest"/></param>
        /// <returns><see cref="GenerateDownloadUrlResponse"/></returns>
        public GenerateDownloadUrlResponse GenerateDownloadUrlSync(GenerateDownloadUrlRequest req)
        {
            return InternalRequestAsync<GenerateDownloadUrlResponse>(req, "GenerateDownloadUrl")
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
        /// This API is used to edit an environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public Task<ModifyNamespaceResponse> ModifyNamespace(ModifyNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyNamespaceResponse>(req, "ModifyNamespace");
        }

        /// <summary>
        /// This API is used to edit an environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyNamespaceRequest"/></param>
        /// <returns><see cref="ModifyNamespaceResponse"/></returns>
        public ModifyNamespaceResponse ModifyNamespaceSync(ModifyNamespaceRequest req)
        {
            return InternalRequestAsync<ModifyNamespaceResponse>(req, "ModifyNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a service’s basic information.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceInfoRequest"/></param>
        /// <returns><see cref="ModifyServiceInfoResponse"/></returns>
        public Task<ModifyServiceInfoResponse> ModifyServiceInfo(ModifyServiceInfoRequest req)
        {
            return InternalRequestAsync<ModifyServiceInfoResponse>(req, "ModifyServiceInfo");
        }

        /// <summary>
        /// This API is used to modify a service’s basic information.
        /// </summary>
        /// <param name="req"><see cref="ModifyServiceInfoRequest"/></param>
        /// <returns><see cref="ModifyServiceInfoResponse"/></returns>
        public ModifyServiceInfoResponse ModifyServiceInfoSync(ModifyServiceInfoRequest req)
        {
            return InternalRequestAsync<ModifyServiceInfoResponse>(req, "ModifyServiceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart an instance.
        /// </summary>
        /// <param name="req"><see cref="RestartServiceRunPodRequest"/></param>
        /// <returns><see cref="RestartServiceRunPodResponse"/></returns>
        public Task<RestartServiceRunPodResponse> RestartServiceRunPod(RestartServiceRunPodRequest req)
        {
            return InternalRequestAsync<RestartServiceRunPodResponse>(req, "RestartServiceRunPod");
        }

        /// <summary>
        /// This API is used to restart an instance.
        /// </summary>
        /// <param name="req"><see cref="RestartServiceRunPodRequest"/></param>
        /// <returns><see cref="RestartServiceRunPodResponse"/></returns>
        public RestartServiceRunPodResponse RestartServiceRunPodSync(RestartServiceRunPodRequest req)
        {
            return InternalRequestAsync<RestartServiceRunPodResponse>(req, "RestartServiceRunPod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
