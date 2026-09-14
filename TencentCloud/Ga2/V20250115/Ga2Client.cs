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

namespace TencentCloud.Ga2.V20250115
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ga2.V20250115.Models;

   public class Ga2Client : AbstractClient{

       private const string endpoint = "ga2.intl.tencentcloudapi.com";
       private const string version = "2025-01-15";
       private const string sdkVersion = "SDK_NET_3.0.1395";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public Ga2Client(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public Ga2Client(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create an acceleration region.
        /// </summary>
        /// <param name="req"><see cref="CreateAccelerateAreasRequest"/></param>
        /// <returns><see cref="CreateAccelerateAreasResponse"/></returns>
        public Task<CreateAccelerateAreasResponse> CreateAccelerateAreas(CreateAccelerateAreasRequest req)
        {
            return InternalRequestAsync<CreateAccelerateAreasResponse>(req, "CreateAccelerateAreas");
        }

        /// <summary>
        /// This API is used to create an acceleration region.
        /// </summary>
        /// <param name="req"><see cref="CreateAccelerateAreasRequest"/></param>
        /// <returns><see cref="CreateAccelerateAreasResponse"/></returns>
        public CreateAccelerateAreasResponse CreateAccelerateAreasSync(CreateAccelerateAreasRequest req)
        {
            return InternalRequestAsync<CreateAccelerateAreasResponse>(req, "CreateAccelerateAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a terminal node group.
        /// </summary>
        /// <param name="req"><see cref="CreateEndpointGroupRequest"/></param>
        /// <returns><see cref="CreateEndpointGroupResponse"/></returns>
        public Task<CreateEndpointGroupResponse> CreateEndpointGroup(CreateEndpointGroupRequest req)
        {
            return InternalRequestAsync<CreateEndpointGroupResponse>(req, "CreateEndpointGroup");
        }

        /// <summary>
        /// This API is used to create a terminal node group.
        /// </summary>
        /// <param name="req"><see cref="CreateEndpointGroupRequest"/></param>
        /// <returns><see cref="CreateEndpointGroupResponse"/></returns>
        public CreateEndpointGroupResponse CreateEndpointGroupSync(CreateEndpointGroupRequest req)
        {
            return InternalRequestAsync<CreateEndpointGroupResponse>(req, "CreateEndpointGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a layer-7 forwarding policy.
        /// </summary>
        /// <param name="req"><see cref="CreateForwardingPolicyRequest"/></param>
        /// <returns><see cref="CreateForwardingPolicyResponse"/></returns>
        public Task<CreateForwardingPolicyResponse> CreateForwardingPolicy(CreateForwardingPolicyRequest req)
        {
            return InternalRequestAsync<CreateForwardingPolicyResponse>(req, "CreateForwardingPolicy");
        }

        /// <summary>
        /// Create a layer-7 forwarding policy.
        /// </summary>
        /// <param name="req"><see cref="CreateForwardingPolicyRequest"/></param>
        /// <returns><see cref="CreateForwardingPolicyResponse"/></returns>
        public CreateForwardingPolicyResponse CreateForwardingPolicySync(CreateForwardingPolicyRequest req)
        {
            return InternalRequestAsync<CreateForwardingPolicyResponse>(req, "CreateForwardingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a Layer 7 forwarding rule
        /// </summary>
        /// <param name="req"><see cref="CreateForwardingRuleRequest"/></param>
        /// <returns><see cref="CreateForwardingRuleResponse"/></returns>
        public Task<CreateForwardingRuleResponse> CreateForwardingRule(CreateForwardingRuleRequest req)
        {
            return InternalRequestAsync<CreateForwardingRuleResponse>(req, "CreateForwardingRule");
        }

        /// <summary>
        /// Create a Layer 7 forwarding rule
        /// </summary>
        /// <param name="req"><see cref="CreateForwardingRuleRequest"/></param>
        /// <returns><see cref="CreateForwardingRuleResponse"/></returns>
        public CreateForwardingRuleResponse CreateForwardingRuleSync(CreateForwardingRuleRequest req)
        {
            return InternalRequestAsync<CreateForwardingRuleResponse>(req, "CreateForwardingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a global acceleration instance.
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="CreateGlobalAcceleratorResponse"/></returns>
        public Task<CreateGlobalAcceleratorResponse> CreateGlobalAccelerator(CreateGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<CreateGlobalAcceleratorResponse>(req, "CreateGlobalAccelerator");
        }

        /// <summary>
        /// This API is used to create a global acceleration instance.
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="CreateGlobalAcceleratorResponse"/></returns>
        public CreateGlobalAcceleratorResponse CreateGlobalAcceleratorSync(CreateGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<CreateGlobalAcceleratorResponse>(req, "CreateGlobalAccelerator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a GA access log
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalAcceleratorAccessLogRequest"/></param>
        /// <returns><see cref="CreateGlobalAcceleratorAccessLogResponse"/></returns>
        public Task<CreateGlobalAcceleratorAccessLogResponse> CreateGlobalAcceleratorAccessLog(CreateGlobalAcceleratorAccessLogRequest req)
        {
            return InternalRequestAsync<CreateGlobalAcceleratorAccessLogResponse>(req, "CreateGlobalAcceleratorAccessLog");
        }

        /// <summary>
        /// Create a GA access log
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalAcceleratorAccessLogRequest"/></param>
        /// <returns><see cref="CreateGlobalAcceleratorAccessLogResponse"/></returns>
        public CreateGlobalAcceleratorAccessLogResponse CreateGlobalAcceleratorAccessLogSync(CreateGlobalAcceleratorAccessLogRequest req)
        {
            return InternalRequestAsync<CreateGlobalAcceleratorAccessLogResponse>(req, "CreateGlobalAcceleratorAccessLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create access control policy
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalAcceleratorAclPolicyRequest"/></param>
        /// <returns><see cref="CreateGlobalAcceleratorAclPolicyResponse"/></returns>
        public Task<CreateGlobalAcceleratorAclPolicyResponse> CreateGlobalAcceleratorAclPolicy(CreateGlobalAcceleratorAclPolicyRequest req)
        {
            return InternalRequestAsync<CreateGlobalAcceleratorAclPolicyResponse>(req, "CreateGlobalAcceleratorAclPolicy");
        }

        /// <summary>
        /// Create access control policy
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalAcceleratorAclPolicyRequest"/></param>
        /// <returns><see cref="CreateGlobalAcceleratorAclPolicyResponse"/></returns>
        public CreateGlobalAcceleratorAclPolicyResponse CreateGlobalAcceleratorAclPolicySync(CreateGlobalAcceleratorAclPolicyRequest req)
        {
            return InternalRequestAsync<CreateGlobalAcceleratorAclPolicyResponse>(req, "CreateGlobalAcceleratorAclPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an ACL rule
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalAcceleratorAclRuleRequest"/></param>
        /// <returns><see cref="CreateGlobalAcceleratorAclRuleResponse"/></returns>
        public Task<CreateGlobalAcceleratorAclRuleResponse> CreateGlobalAcceleratorAclRule(CreateGlobalAcceleratorAclRuleRequest req)
        {
            return InternalRequestAsync<CreateGlobalAcceleratorAclRuleResponse>(req, "CreateGlobalAcceleratorAclRule");
        }

        /// <summary>
        /// Create an ACL rule
        /// </summary>
        /// <param name="req"><see cref="CreateGlobalAcceleratorAclRuleRequest"/></param>
        /// <returns><see cref="CreateGlobalAcceleratorAclRuleResponse"/></returns>
        public CreateGlobalAcceleratorAclRuleResponse CreateGlobalAcceleratorAclRuleSync(CreateGlobalAcceleratorAclRuleRequest req)
        {
            return InternalRequestAsync<CreateGlobalAcceleratorAclRuleResponse>(req, "CreateGlobalAcceleratorAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a listener.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public Task<CreateListenerResponse> CreateListener(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener");
        }

        /// <summary>
        /// This API is used to create a listener.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerRequest"/></param>
        /// <returns><see cref="CreateListenerResponse"/></returns>
        public CreateListenerResponse CreateListenerSync(CreateListenerRequest req)
        {
            return InternalRequestAsync<CreateListenerResponse>(req, "CreateListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add an extension certificate.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerAdditionalCertRequest"/></param>
        /// <returns><see cref="CreateListenerAdditionalCertResponse"/></returns>
        public Task<CreateListenerAdditionalCertResponse> CreateListenerAdditionalCert(CreateListenerAdditionalCertRequest req)
        {
            return InternalRequestAsync<CreateListenerAdditionalCertResponse>(req, "CreateListenerAdditionalCert");
        }

        /// <summary>
        /// Add an extension certificate.
        /// </summary>
        /// <param name="req"><see cref="CreateListenerAdditionalCertRequest"/></param>
        /// <returns><see cref="CreateListenerAdditionalCertResponse"/></returns>
        public CreateListenerAdditionalCertResponse CreateListenerAdditionalCertSync(CreateListenerAdditionalCertRequest req)
        {
            return InternalRequestAsync<CreateListenerAdditionalCertResponse>(req, "CreateListenerAdditionalCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an acceleration region
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerateAreasRequest"/></param>
        /// <returns><see cref="DeleteAccelerateAreasResponse"/></returns>
        public Task<DeleteAccelerateAreasResponse> DeleteAccelerateAreas(DeleteAccelerateAreasRequest req)
        {
            return InternalRequestAsync<DeleteAccelerateAreasResponse>(req, "DeleteAccelerateAreas");
        }

        /// <summary>
        /// Delete an acceleration region
        /// </summary>
        /// <param name="req"><see cref="DeleteAccelerateAreasRequest"/></param>
        /// <returns><see cref="DeleteAccelerateAreasResponse"/></returns>
        public DeleteAccelerateAreasResponse DeleteAccelerateAreasSync(DeleteAccelerateAreasRequest req)
        {
            return InternalRequestAsync<DeleteAccelerateAreasResponse>(req, "DeleteAccelerateAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a terminal node group.
        /// </summary>
        /// <param name="req"><see cref="DeleteEndpointGroupsRequest"/></param>
        /// <returns><see cref="DeleteEndpointGroupsResponse"/></returns>
        public Task<DeleteEndpointGroupsResponse> DeleteEndpointGroups(DeleteEndpointGroupsRequest req)
        {
            return InternalRequestAsync<DeleteEndpointGroupsResponse>(req, "DeleteEndpointGroups");
        }

        /// <summary>
        /// Delete a terminal node group.
        /// </summary>
        /// <param name="req"><see cref="DeleteEndpointGroupsRequest"/></param>
        /// <returns><see cref="DeleteEndpointGroupsResponse"/></returns>
        public DeleteEndpointGroupsResponse DeleteEndpointGroupsSync(DeleteEndpointGroupsRequest req)
        {
            return InternalRequestAsync<DeleteEndpointGroupsResponse>(req, "DeleteEndpointGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a layer-7 forwarding policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardingPolicyRequest"/></param>
        /// <returns><see cref="DeleteForwardingPolicyResponse"/></returns>
        public Task<DeleteForwardingPolicyResponse> DeleteForwardingPolicy(DeleteForwardingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteForwardingPolicyResponse>(req, "DeleteForwardingPolicy");
        }

        /// <summary>
        /// Delete a layer-7 forwarding policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardingPolicyRequest"/></param>
        /// <returns><see cref="DeleteForwardingPolicyResponse"/></returns>
        public DeleteForwardingPolicyResponse DeleteForwardingPolicySync(DeleteForwardingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteForwardingPolicyResponse>(req, "DeleteForwardingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Layer 7 forwarding rule
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardingRuleRequest"/></param>
        /// <returns><see cref="DeleteForwardingRuleResponse"/></returns>
        public Task<DeleteForwardingRuleResponse> DeleteForwardingRule(DeleteForwardingRuleRequest req)
        {
            return InternalRequestAsync<DeleteForwardingRuleResponse>(req, "DeleteForwardingRule");
        }

        /// <summary>
        /// Delete a Layer 7 forwarding rule
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardingRuleRequest"/></param>
        /// <returns><see cref="DeleteForwardingRuleResponse"/></returns>
        public DeleteForwardingRuleResponse DeleteForwardingRuleSync(DeleteForwardingRuleRequest req)
        {
            return InternalRequestAsync<DeleteForwardingRuleResponse>(req, "DeleteForwardingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a global acceleration instance
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="DeleteGlobalAcceleratorResponse"/></returns>
        public Task<DeleteGlobalAcceleratorResponse> DeleteGlobalAccelerator(DeleteGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<DeleteGlobalAcceleratorResponse>(req, "DeleteGlobalAccelerator");
        }

        /// <summary>
        /// Deletes a global acceleration instance
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="DeleteGlobalAcceleratorResponse"/></returns>
        public DeleteGlobalAcceleratorResponse DeleteGlobalAcceleratorSync(DeleteGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<DeleteGlobalAcceleratorResponse>(req, "DeleteGlobalAccelerator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a GA log task.
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalAcceleratorAccessLogRequest"/></param>
        /// <returns><see cref="DeleteGlobalAcceleratorAccessLogResponse"/></returns>
        public Task<DeleteGlobalAcceleratorAccessLogResponse> DeleteGlobalAcceleratorAccessLog(DeleteGlobalAcceleratorAccessLogRequest req)
        {
            return InternalRequestAsync<DeleteGlobalAcceleratorAccessLogResponse>(req, "DeleteGlobalAcceleratorAccessLog");
        }

        /// <summary>
        /// This API is used to delete a GA log task.
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalAcceleratorAccessLogRequest"/></param>
        /// <returns><see cref="DeleteGlobalAcceleratorAccessLogResponse"/></returns>
        public DeleteGlobalAcceleratorAccessLogResponse DeleteGlobalAcceleratorAccessLogSync(DeleteGlobalAcceleratorAccessLogRequest req)
        {
            return InternalRequestAsync<DeleteGlobalAcceleratorAccessLogResponse>(req, "DeleteGlobalAcceleratorAccessLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete access control policy
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalAcceleratorAclPolicyRequest"/></param>
        /// <returns><see cref="DeleteGlobalAcceleratorAclPolicyResponse"/></returns>
        public Task<DeleteGlobalAcceleratorAclPolicyResponse> DeleteGlobalAcceleratorAclPolicy(DeleteGlobalAcceleratorAclPolicyRequest req)
        {
            return InternalRequestAsync<DeleteGlobalAcceleratorAclPolicyResponse>(req, "DeleteGlobalAcceleratorAclPolicy");
        }

        /// <summary>
        /// Delete access control policy
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalAcceleratorAclPolicyRequest"/></param>
        /// <returns><see cref="DeleteGlobalAcceleratorAclPolicyResponse"/></returns>
        public DeleteGlobalAcceleratorAclPolicyResponse DeleteGlobalAcceleratorAclPolicySync(DeleteGlobalAcceleratorAclPolicyRequest req)
        {
            return InternalRequestAsync<DeleteGlobalAcceleratorAclPolicyResponse>(req, "DeleteGlobalAcceleratorAclPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete ACL rule
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalAcceleratorAclRuleRequest"/></param>
        /// <returns><see cref="DeleteGlobalAcceleratorAclRuleResponse"/></returns>
        public Task<DeleteGlobalAcceleratorAclRuleResponse> DeleteGlobalAcceleratorAclRule(DeleteGlobalAcceleratorAclRuleRequest req)
        {
            return InternalRequestAsync<DeleteGlobalAcceleratorAclRuleResponse>(req, "DeleteGlobalAcceleratorAclRule");
        }

        /// <summary>
        /// Delete ACL rule
        /// </summary>
        /// <param name="req"><see cref="DeleteGlobalAcceleratorAclRuleRequest"/></param>
        /// <returns><see cref="DeleteGlobalAcceleratorAclRuleResponse"/></returns>
        public DeleteGlobalAcceleratorAclRuleResponse DeleteGlobalAcceleratorAclRuleSync(DeleteGlobalAcceleratorAclRuleRequest req)
        {
            return InternalRequestAsync<DeleteGlobalAcceleratorAclRuleResponse>(req, "DeleteGlobalAcceleratorAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a listener.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public Task<DeleteListenerResponse> DeleteListener(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener");
        }

        /// <summary>
        /// This API is used to delete a listener.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerRequest"/></param>
        /// <returns><see cref="DeleteListenerResponse"/></returns>
        public DeleteListenerResponse DeleteListenerSync(DeleteListenerRequest req)
        {
            return InternalRequestAsync<DeleteListenerResponse>(req, "DeleteListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the extension certificate.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerAdditionalCertRequest"/></param>
        /// <returns><see cref="DeleteListenerAdditionalCertResponse"/></returns>
        public Task<DeleteListenerAdditionalCertResponse> DeleteListenerAdditionalCert(DeleteListenerAdditionalCertRequest req)
        {
            return InternalRequestAsync<DeleteListenerAdditionalCertResponse>(req, "DeleteListenerAdditionalCert");
        }

        /// <summary>
        /// Delete the extension certificate.
        /// </summary>
        /// <param name="req"><see cref="DeleteListenerAdditionalCertRequest"/></param>
        /// <returns><see cref="DeleteListenerAdditionalCertResponse"/></returns>
        public DeleteListenerAdditionalCertResponse DeleteListenerAdditionalCertSync(DeleteListenerAdditionalCertRequest req)
        {
            return InternalRequestAsync<DeleteListenerAdditionalCertResponse>(req, "DeleteListenerAdditionalCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries acceleration regions
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerateAreasRequest"/></param>
        /// <returns><see cref="DescribeAccelerateAreasResponse"/></returns>
        public Task<DescribeAccelerateAreasResponse> DescribeAccelerateAreas(DescribeAccelerateAreasRequest req)
        {
            return InternalRequestAsync<DescribeAccelerateAreasResponse>(req, "DescribeAccelerateAreas");
        }

        /// <summary>
        /// Queries acceleration regions
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerateAreasRequest"/></param>
        /// <returns><see cref="DescribeAccelerateAreasResponse"/></returns>
        public DescribeAccelerateAreasResponse DescribeAccelerateAreasSync(DescribeAccelerateAreasRequest req)
        {
            return InternalRequestAsync<DescribeAccelerateAreasResponse>(req, "DescribeAccelerateAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries selectable acceleration regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerateRegionsRequest"/></param>
        /// <returns><see cref="DescribeAccelerateRegionsResponse"/></returns>
        public Task<DescribeAccelerateRegionsResponse> DescribeAccelerateRegions(DescribeAccelerateRegionsRequest req)
        {
            return InternalRequestAsync<DescribeAccelerateRegionsResponse>(req, "DescribeAccelerateRegions");
        }

        /// <summary>
        /// Queries selectable acceleration regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccelerateRegionsRequest"/></param>
        /// <returns><see cref="DescribeAccelerateRegionsResponse"/></returns>
        public DescribeAccelerateRegionsResponse DescribeAccelerateRegionsSync(DescribeAccelerateRegionsRequest req)
        {
            return InternalRequestAsync<DescribeAccelerateRegionsResponse>(req, "DescribeAccelerateRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View access log reporting parameters
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessLogParamRequest"/></param>
        /// <returns><see cref="DescribeAccessLogParamResponse"/></returns>
        public Task<DescribeAccessLogParamResponse> DescribeAccessLogParam(DescribeAccessLogParamRequest req)
        {
            return InternalRequestAsync<DescribeAccessLogParamResponse>(req, "DescribeAccessLogParam");
        }

        /// <summary>
        /// View access log reporting parameters
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessLogParamRequest"/></param>
        /// <returns><see cref="DescribeAccessLogParamResponse"/></returns>
        public DescribeAccessLogParamResponse DescribeAccessLogParamSync(DescribeAccessLogParamRequest req)
        {
            return InternalRequestAsync<DescribeAccessLogParamResponse>(req, "DescribeAccessLogParam")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying Cross-Border Bills
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderSettlementRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderSettlementResponse"/></returns>
        public Task<DescribeCrossBorderSettlementResponse> DescribeCrossBorderSettlement(DescribeCrossBorderSettlementRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderSettlementResponse>(req, "DescribeCrossBorderSettlement");
        }

        /// <summary>
        /// Querying Cross-Border Bills
        /// </summary>
        /// <param name="req"><see cref="DescribeCrossBorderSettlementRequest"/></param>
        /// <returns><see cref="DescribeCrossBorderSettlementResponse"/></returns>
        public DescribeCrossBorderSettlementResponse DescribeCrossBorderSettlementSync(DescribeCrossBorderSettlementRequest req)
        {
            return InternalRequestAsync<DescribeCrossBorderSettlementResponse>(req, "DescribeCrossBorderSettlement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query a terminal node group.
        /// </summary>
        /// <param name="req"><see cref="DescribeEndpointGroupsRequest"/></param>
        /// <returns><see cref="DescribeEndpointGroupsResponse"/></returns>
        public Task<DescribeEndpointGroupsResponse> DescribeEndpointGroups(DescribeEndpointGroupsRequest req)
        {
            return InternalRequestAsync<DescribeEndpointGroupsResponse>(req, "DescribeEndpointGroups");
        }

        /// <summary>
        /// Query a terminal node group.
        /// </summary>
        /// <param name="req"><see cref="DescribeEndpointGroupsRequest"/></param>
        /// <returns><see cref="DescribeEndpointGroupsResponse"/></returns>
        public DescribeEndpointGroupsResponse DescribeEndpointGroupsSync(DescribeEndpointGroupsRequest req)
        {
            return InternalRequestAsync<DescribeEndpointGroupsResponse>(req, "DescribeEndpointGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View a layer-7 forwarding policy
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardingPolicyRequest"/></param>
        /// <returns><see cref="DescribeForwardingPolicyResponse"/></returns>
        public Task<DescribeForwardingPolicyResponse> DescribeForwardingPolicy(DescribeForwardingPolicyRequest req)
        {
            return InternalRequestAsync<DescribeForwardingPolicyResponse>(req, "DescribeForwardingPolicy");
        }

        /// <summary>
        /// View a layer-7 forwarding policy
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardingPolicyRequest"/></param>
        /// <returns><see cref="DescribeForwardingPolicyResponse"/></returns>
        public DescribeForwardingPolicyResponse DescribeForwardingPolicySync(DescribeForwardingPolicyRequest req)
        {
            return InternalRequestAsync<DescribeForwardingPolicyResponse>(req, "DescribeForwardingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View a Layer 7 forwarding rule
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardingRuleRequest"/></param>
        /// <returns><see cref="DescribeForwardingRuleResponse"/></returns>
        public Task<DescribeForwardingRuleResponse> DescribeForwardingRule(DescribeForwardingRuleRequest req)
        {
            return InternalRequestAsync<DescribeForwardingRuleResponse>(req, "DescribeForwardingRule");
        }

        /// <summary>
        /// View a Layer 7 forwarding rule
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardingRuleRequest"/></param>
        /// <returns><see cref="DescribeForwardingRuleResponse"/></returns>
        public DescribeForwardingRuleResponse DescribeForwardingRuleSync(DescribeForwardingRuleRequest req)
        {
            return InternalRequestAsync<DescribeForwardingRuleResponse>(req, "DescribeForwardingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query log tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalAcceleratorAccessLogRequest"/></param>
        /// <returns><see cref="DescribeGlobalAcceleratorAccessLogResponse"/></returns>
        public Task<DescribeGlobalAcceleratorAccessLogResponse> DescribeGlobalAcceleratorAccessLog(DescribeGlobalAcceleratorAccessLogRequest req)
        {
            return InternalRequestAsync<DescribeGlobalAcceleratorAccessLogResponse>(req, "DescribeGlobalAcceleratorAccessLog");
        }

        /// <summary>
        /// Query log tasks
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalAcceleratorAccessLogRequest"/></param>
        /// <returns><see cref="DescribeGlobalAcceleratorAccessLogResponse"/></returns>
        public DescribeGlobalAcceleratorAccessLogResponse DescribeGlobalAcceleratorAccessLogSync(DescribeGlobalAcceleratorAccessLogRequest req)
        {
            return InternalRequestAsync<DescribeGlobalAcceleratorAccessLogResponse>(req, "DescribeGlobalAcceleratorAccessLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View the access control policy
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalAcceleratorAclPoliciesRequest"/></param>
        /// <returns><see cref="DescribeGlobalAcceleratorAclPoliciesResponse"/></returns>
        public Task<DescribeGlobalAcceleratorAclPoliciesResponse> DescribeGlobalAcceleratorAclPolicies(DescribeGlobalAcceleratorAclPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeGlobalAcceleratorAclPoliciesResponse>(req, "DescribeGlobalAcceleratorAclPolicies");
        }

        /// <summary>
        /// View the access control policy
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalAcceleratorAclPoliciesRequest"/></param>
        /// <returns><see cref="DescribeGlobalAcceleratorAclPoliciesResponse"/></returns>
        public DescribeGlobalAcceleratorAclPoliciesResponse DescribeGlobalAcceleratorAclPoliciesSync(DescribeGlobalAcceleratorAclPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeGlobalAcceleratorAclPoliciesResponse>(req, "DescribeGlobalAcceleratorAclPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View ACL rules
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalAcceleratorAclRulesRequest"/></param>
        /// <returns><see cref="DescribeGlobalAcceleratorAclRulesResponse"/></returns>
        public Task<DescribeGlobalAcceleratorAclRulesResponse> DescribeGlobalAcceleratorAclRules(DescribeGlobalAcceleratorAclRulesRequest req)
        {
            return InternalRequestAsync<DescribeGlobalAcceleratorAclRulesResponse>(req, "DescribeGlobalAcceleratorAclRules");
        }

        /// <summary>
        /// View ACL rules
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalAcceleratorAclRulesRequest"/></param>
        /// <returns><see cref="DescribeGlobalAcceleratorAclRulesResponse"/></returns>
        public DescribeGlobalAcceleratorAclRulesResponse DescribeGlobalAcceleratorAclRulesSync(DescribeGlobalAcceleratorAclRulesRequest req)
        {
            return InternalRequestAsync<DescribeGlobalAcceleratorAclRulesResponse>(req, "DescribeGlobalAcceleratorAclRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a global acceleration instance
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalAcceleratorsRequest"/></param>
        /// <returns><see cref="DescribeGlobalAcceleratorsResponse"/></returns>
        public Task<DescribeGlobalAcceleratorsResponse> DescribeGlobalAccelerators(DescribeGlobalAcceleratorsRequest req)
        {
            return InternalRequestAsync<DescribeGlobalAcceleratorsResponse>(req, "DescribeGlobalAccelerators");
        }

        /// <summary>
        /// Modify a global acceleration instance
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalAcceleratorsRequest"/></param>
        /// <returns><see cref="DescribeGlobalAcceleratorsResponse"/></returns>
        public DescribeGlobalAcceleratorsResponse DescribeGlobalAcceleratorsSync(DescribeGlobalAcceleratorsRequest req)
        {
            return InternalRequestAsync<DescribeGlobalAcceleratorsResponse>(req, "DescribeGlobalAccelerators")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public Task<DescribeListenersResponse> DescribeListeners(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners");
        }

        /// <summary>
        /// This API is used to query listeners.
        /// </summary>
        /// <param name="req"><see cref="DescribeListenersRequest"/></param>
        /// <returns><see cref="DescribeListenersResponse"/></returns>
        public DescribeListenersResponse DescribeListenersSync(DescribeListenersRequest req)
        {
            return InternalRequestAsync<DescribeListenersResponse>(req, "DescribeListeners")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query asynchronous task result
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult");
        }

        /// <summary>
        /// Query asynchronous task result
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify acceleration region
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerateAreasRequest"/></param>
        /// <returns><see cref="ModifyAccelerateAreasResponse"/></returns>
        public Task<ModifyAccelerateAreasResponse> ModifyAccelerateAreas(ModifyAccelerateAreasRequest req)
        {
            return InternalRequestAsync<ModifyAccelerateAreasResponse>(req, "ModifyAccelerateAreas");
        }

        /// <summary>
        /// Modify acceleration region
        /// </summary>
        /// <param name="req"><see cref="ModifyAccelerateAreasRequest"/></param>
        /// <returns><see cref="ModifyAccelerateAreasResponse"/></returns>
        public ModifyAccelerateAreasResponse ModifyAccelerateAreasSync(ModifyAccelerateAreasRequest req)
        {
            return InternalRequestAsync<ModifyAccelerateAreasResponse>(req, "ModifyAccelerateAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the status of a log task
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessLogStatusRequest"/></param>
        /// <returns><see cref="ModifyAccessLogStatusResponse"/></returns>
        public Task<ModifyAccessLogStatusResponse> ModifyAccessLogStatus(ModifyAccessLogStatusRequest req)
        {
            return InternalRequestAsync<ModifyAccessLogStatusResponse>(req, "ModifyAccessLogStatus");
        }

        /// <summary>
        /// Modify the status of a log task
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessLogStatusRequest"/></param>
        /// <returns><see cref="ModifyAccessLogStatusResponse"/></returns>
        public ModifyAccessLogStatusResponse ModifyAccessLogStatusSync(ModifyAccessLogStatusRequest req)
        {
            return InternalRequestAsync<ModifyAccessLogStatusResponse>(req, "ModifyAccessLogStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a terminal node group.
        /// </summary>
        /// <param name="req"><see cref="ModifyEndpointGroupRequest"/></param>
        /// <returns><see cref="ModifyEndpointGroupResponse"/></returns>
        public Task<ModifyEndpointGroupResponse> ModifyEndpointGroup(ModifyEndpointGroupRequest req)
        {
            return InternalRequestAsync<ModifyEndpointGroupResponse>(req, "ModifyEndpointGroup");
        }

        /// <summary>
        /// This API is used to modify a terminal node group.
        /// </summary>
        /// <param name="req"><see cref="ModifyEndpointGroupRequest"/></param>
        /// <returns><see cref="ModifyEndpointGroupResponse"/></returns>
        public ModifyEndpointGroupResponse ModifyEndpointGroupSync(ModifyEndpointGroupRequest req)
        {
            return InternalRequestAsync<ModifyEndpointGroupResponse>(req, "ModifyEndpointGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a layer-7 forwarding policy
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardingPolicyRequest"/></param>
        /// <returns><see cref="ModifyForwardingPolicyResponse"/></returns>
        public Task<ModifyForwardingPolicyResponse> ModifyForwardingPolicy(ModifyForwardingPolicyRequest req)
        {
            return InternalRequestAsync<ModifyForwardingPolicyResponse>(req, "ModifyForwardingPolicy");
        }

        /// <summary>
        /// Modify a layer-7 forwarding policy
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardingPolicyRequest"/></param>
        /// <returns><see cref="ModifyForwardingPolicyResponse"/></returns>
        public ModifyForwardingPolicyResponse ModifyForwardingPolicySync(ModifyForwardingPolicyRequest req)
        {
            return InternalRequestAsync<ModifyForwardingPolicyResponse>(req, "ModifyForwardingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a Layer 7 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardingRuleRequest"/></param>
        /// <returns><see cref="ModifyForwardingRuleResponse"/></returns>
        public Task<ModifyForwardingRuleResponse> ModifyForwardingRule(ModifyForwardingRuleRequest req)
        {
            return InternalRequestAsync<ModifyForwardingRuleResponse>(req, "ModifyForwardingRule");
        }

        /// <summary>
        /// This API is used to modify a Layer 7 forwarding rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardingRuleRequest"/></param>
        /// <returns><see cref="ModifyForwardingRuleResponse"/></returns>
        public ModifyForwardingRuleResponse ModifyForwardingRuleSync(ModifyForwardingRuleRequest req)
        {
            return InternalRequestAsync<ModifyForwardingRuleResponse>(req, "ModifyForwardingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a global acceleration instance
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="ModifyGlobalAcceleratorResponse"/></returns>
        public Task<ModifyGlobalAcceleratorResponse> ModifyGlobalAccelerator(ModifyGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<ModifyGlobalAcceleratorResponse>(req, "ModifyGlobalAccelerator");
        }

        /// <summary>
        /// Modify a global acceleration instance
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalAcceleratorRequest"/></param>
        /// <returns><see cref="ModifyGlobalAcceleratorResponse"/></returns>
        public ModifyGlobalAcceleratorResponse ModifyGlobalAcceleratorSync(ModifyGlobalAcceleratorRequest req)
        {
            return InternalRequestAsync<ModifyGlobalAcceleratorResponse>(req, "ModifyGlobalAccelerator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify GA access logs
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalAcceleratorAccessLogRequest"/></param>
        /// <returns><see cref="ModifyGlobalAcceleratorAccessLogResponse"/></returns>
        public Task<ModifyGlobalAcceleratorAccessLogResponse> ModifyGlobalAcceleratorAccessLog(ModifyGlobalAcceleratorAccessLogRequest req)
        {
            return InternalRequestAsync<ModifyGlobalAcceleratorAccessLogResponse>(req, "ModifyGlobalAcceleratorAccessLog");
        }

        /// <summary>
        /// Modify GA access logs
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalAcceleratorAccessLogRequest"/></param>
        /// <returns><see cref="ModifyGlobalAcceleratorAccessLogResponse"/></returns>
        public ModifyGlobalAcceleratorAccessLogResponse ModifyGlobalAcceleratorAccessLogSync(ModifyGlobalAcceleratorAccessLogRequest req)
        {
            return InternalRequestAsync<ModifyGlobalAcceleratorAccessLogResponse>(req, "ModifyGlobalAcceleratorAccessLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the status of an access control policy
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalAcceleratorAclPolicyRequest"/></param>
        /// <returns><see cref="ModifyGlobalAcceleratorAclPolicyResponse"/></returns>
        public Task<ModifyGlobalAcceleratorAclPolicyResponse> ModifyGlobalAcceleratorAclPolicy(ModifyGlobalAcceleratorAclPolicyRequest req)
        {
            return InternalRequestAsync<ModifyGlobalAcceleratorAclPolicyResponse>(req, "ModifyGlobalAcceleratorAclPolicy");
        }

        /// <summary>
        /// Modify the status of an access control policy
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalAcceleratorAclPolicyRequest"/></param>
        /// <returns><see cref="ModifyGlobalAcceleratorAclPolicyResponse"/></returns>
        public ModifyGlobalAcceleratorAclPolicyResponse ModifyGlobalAcceleratorAclPolicySync(ModifyGlobalAcceleratorAclPolicyRequest req)
        {
            return InternalRequestAsync<ModifyGlobalAcceleratorAclPolicyResponse>(req, "ModifyGlobalAcceleratorAclPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify ACL rules
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalAcceleratorAclRuleRequest"/></param>
        /// <returns><see cref="ModifyGlobalAcceleratorAclRuleResponse"/></returns>
        public Task<ModifyGlobalAcceleratorAclRuleResponse> ModifyGlobalAcceleratorAclRule(ModifyGlobalAcceleratorAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyGlobalAcceleratorAclRuleResponse>(req, "ModifyGlobalAcceleratorAclRule");
        }

        /// <summary>
        /// Modify ACL rules
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalAcceleratorAclRuleRequest"/></param>
        /// <returns><see cref="ModifyGlobalAcceleratorAclRuleResponse"/></returns>
        public ModifyGlobalAcceleratorAclRuleResponse ModifyGlobalAcceleratorAclRuleSync(ModifyGlobalAcceleratorAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyGlobalAcceleratorAclRuleResponse>(req, "ModifyGlobalAcceleratorAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a listener
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public Task<ModifyListenerResponse> ModifyListener(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener");
        }

        /// <summary>
        /// Modify a listener
        /// </summary>
        /// <param name="req"><see cref="ModifyListenerRequest"/></param>
        /// <returns><see cref="ModifyListenerResponse"/></returns>
        public ModifyListenerResponse ModifyListenerSync(ModifyListenerRequest req)
        {
            return InternalRequestAsync<ModifyListenerResponse>(req, "ModifyListener")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Replace the extension certificate.
        /// </summary>
        /// <param name="req"><see cref="ReplaceListenerAdditionalCertRequest"/></param>
        /// <returns><see cref="ReplaceListenerAdditionalCertResponse"/></returns>
        public Task<ReplaceListenerAdditionalCertResponse> ReplaceListenerAdditionalCert(ReplaceListenerAdditionalCertRequest req)
        {
            return InternalRequestAsync<ReplaceListenerAdditionalCertResponse>(req, "ReplaceListenerAdditionalCert");
        }

        /// <summary>
        /// Replace the extension certificate.
        /// </summary>
        /// <param name="req"><see cref="ReplaceListenerAdditionalCertRequest"/></param>
        /// <returns><see cref="ReplaceListenerAdditionalCertResponse"/></returns>
        public ReplaceListenerAdditionalCertResponse ReplaceListenerAdditionalCertSync(ReplaceListenerAdditionalCertRequest req)
        {
            return InternalRequestAsync<ReplaceListenerAdditionalCertResponse>(req, "ReplaceListenerAdditionalCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
