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

namespace TencentCloud.Organization.V20210331
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Organization.V20210331.Models;

   public class OrganizationClient : AbstractClient{

       private const string endpoint = "organization.tencentcloudapi.com";
       private const string version = "2021-03-31";
       private const string sdkVersion = "SDK_NET_3.0.922";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public OrganizationClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public OrganizationClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add an organization node.
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationNodeRequest"/></param>
        /// <returns><see cref="AddOrganizationNodeResponse"/></returns>
        public Task<AddOrganizationNodeResponse> AddOrganizationNode(AddOrganizationNodeRequest req)
        {
            return InternalRequestAsync<AddOrganizationNodeResponse>(req, "AddOrganizationNode");
        }

        /// <summary>
        /// This API is used to add an organization node.
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationNodeRequest"/></param>
        /// <returns><see cref="AddOrganizationNodeResponse"/></returns>
        public AddOrganizationNodeResponse AddOrganizationNodeSync(AddOrganizationNodeRequest req)
        {
            return InternalRequestAsync<AddOrganizationNodeResponse>(req, "AddOrganizationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an organization member to a sub-account of the organization admin.
        /// </summary>
        /// <param name="req"><see cref="BindOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="BindOrganizationMemberAuthAccountResponse"/></returns>
        public Task<BindOrganizationMemberAuthAccountResponse> BindOrganizationMemberAuthAccount(BindOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<BindOrganizationMemberAuthAccountResponse>(req, "BindOrganizationMemberAuthAccount");
        }

        /// <summary>
        /// This API is used to bind an organization member to a sub-account of the organization admin.
        /// </summary>
        /// <param name="req"><see cref="BindOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="BindOrganizationMemberAuthAccountResponse"/></returns>
        public BindOrganizationMemberAuthAccountResponse BindOrganizationMemberAuthAccountSync(BindOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<BindOrganizationMemberAuthAccountResponse>(req, "BindOrganizationMemberAuthAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind an organization member from a sub-account of the organization admin.
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="CancelOrganizationMemberAuthAccountResponse"/></returns>
        public Task<CancelOrganizationMemberAuthAccountResponse> CancelOrganizationMemberAuthAccount(CancelOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<CancelOrganizationMemberAuthAccountResponse>(req, "CancelOrganizationMemberAuthAccount");
        }

        /// <summary>
        /// This API is used to unbind an organization member from a sub-account of the organization admin.
        /// </summary>
        /// <param name="req"><see cref="CancelOrganizationMemberAuthAccountRequest"/></param>
        /// <returns><see cref="CancelOrganizationMemberAuthAccountResponse"/></returns>
        public CancelOrganizationMemberAuthAccountResponse CancelOrganizationMemberAuthAccountSync(CancelOrganizationMemberAuthAccountRequest req)
        {
            return InternalRequestAsync<CancelOrganizationMemberAuthAccountResponse>(req, "CancelOrganizationMemberAuthAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an organization member.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberResponse"/></returns>
        public Task<CreateOrganizationMemberResponse> CreateOrganizationMember(CreateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberResponse>(req, "CreateOrganizationMember");
        }

        /// <summary>
        /// This API is used to create an organization member.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberResponse"/></returns>
        public CreateOrganizationMemberResponse CreateOrganizationMemberSync(CreateOrganizationMemberRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberResponse>(req, "CreateOrganizationMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an organization member access policy.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberPolicyResponse"/></returns>
        public Task<CreateOrganizationMemberPolicyResponse> CreateOrganizationMemberPolicy(CreateOrganizationMemberPolicyRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberPolicyResponse>(req, "CreateOrganizationMemberPolicy");
        }

        /// <summary>
        /// This API is used to create an organization member access policy.
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationMemberPolicyRequest"/></param>
        /// <returns><see cref="CreateOrganizationMemberPolicyResponse"/></returns>
        public CreateOrganizationMemberPolicyResponse CreateOrganizationMemberPolicySync(CreateOrganizationMemberPolicyRequest req)
        {
            return InternalRequestAsync<CreateOrganizationMemberPolicyResponse>(req, "CreateOrganizationMemberPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete organization members.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersResponse"/></returns>
        public Task<DeleteOrganizationMembersResponse> DeleteOrganizationMembers(DeleteOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersResponse>(req, "DeleteOrganizationMembers");
        }

        /// <summary>
        /// This API is used to batch delete organization members.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationMembersRequest"/></param>
        /// <returns><see cref="DeleteOrganizationMembersResponse"/></returns>
        public DeleteOrganizationMembersResponse DeleteOrganizationMembersSync(DeleteOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationMembersResponse>(req, "DeleteOrganizationMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete organization nodes.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns><see cref="DeleteOrganizationNodesResponse"/></returns>
        public Task<DeleteOrganizationNodesResponse> DeleteOrganizationNodes(DeleteOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationNodesResponse>(req, "DeleteOrganizationNodes");
        }

        /// <summary>
        /// This API is used to batch delete organization nodes.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationNodesRequest"/></param>
        /// <returns><see cref="DeleteOrganizationNodesResponse"/></returns>
        public DeleteOrganizationNodesResponse DeleteOrganizationNodesSync(DeleteOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationNodesResponse>(req, "DeleteOrganizationNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the organization information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public Task<DescribeOrganizationResponse> DescribeOrganization(DescribeOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationResponse>(req, "DescribeOrganization");
        }

        /// <summary>
        /// This API is used to get the organization information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public DescribeOrganizationResponse DescribeOrganizationSync(DescribeOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationResponse>(req, "DescribeOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of sub-accounts bound to an organization member.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthAccountsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthAccountsResponse"/></returns>
        public Task<DescribeOrganizationMemberAuthAccountsResponse> DescribeOrganizationMemberAuthAccounts(DescribeOrganizationMemberAuthAccountsRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthAccountsResponse>(req, "DescribeOrganizationMemberAuthAccounts");
        }

        /// <summary>
        /// This API is used to get the list of sub-accounts bound to an organization member.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthAccountsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthAccountsResponse"/></returns>
        public DescribeOrganizationMemberAuthAccountsResponse DescribeOrganizationMemberAuthAccountsSync(DescribeOrganizationMemberAuthAccountsRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthAccountsResponse>(req, "DescribeOrganizationMemberAuthAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of manageable identities of an organization member.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthIdentitiesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthIdentitiesResponse"/></returns>
        public Task<DescribeOrganizationMemberAuthIdentitiesResponse> DescribeOrganizationMemberAuthIdentities(DescribeOrganizationMemberAuthIdentitiesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthIdentitiesResponse>(req, "DescribeOrganizationMemberAuthIdentities");
        }

        /// <summary>
        /// This API is used to get the list of manageable identities of an organization member.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberAuthIdentitiesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberAuthIdentitiesResponse"/></returns>
        public DescribeOrganizationMemberAuthIdentitiesResponse DescribeOrganizationMemberAuthIdentitiesSync(DescribeOrganizationMemberAuthIdentitiesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberAuthIdentitiesResponse>(req, "DescribeOrganizationMemberAuthIdentities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of authorization policies of an organization member.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberPoliciesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberPoliciesResponse"/></returns>
        public Task<DescribeOrganizationMemberPoliciesResponse> DescribeOrganizationMemberPolicies(DescribeOrganizationMemberPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberPoliciesResponse>(req, "DescribeOrganizationMemberPolicies");
        }

        /// <summary>
        /// This API is used to get the list of authorization policies of an organization member.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMemberPoliciesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMemberPoliciesResponse"/></returns>
        public DescribeOrganizationMemberPoliciesResponse DescribeOrganizationMemberPoliciesSync(DescribeOrganizationMemberPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMemberPoliciesResponse>(req, "DescribeOrganizationMemberPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of organization members.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMembersRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMembersResponse"/></returns>
        public Task<DescribeOrganizationMembersResponse> DescribeOrganizationMembers(DescribeOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMembersResponse>(req, "DescribeOrganizationMembers");
        }

        /// <summary>
        /// This API is used to get the list of organization members.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationMembersRequest"/></param>
        /// <returns><see cref="DescribeOrganizationMembersResponse"/></returns>
        public DescribeOrganizationMembersResponse DescribeOrganizationMembersSync(DescribeOrganizationMembersRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationMembersResponse>(req, "DescribeOrganizationMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of organization nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationNodesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationNodesResponse"/></returns>
        public Task<DescribeOrganizationNodesResponse> DescribeOrganizationNodes(DescribeOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationNodesResponse>(req, "DescribeOrganizationNodes");
        }

        /// <summary>
        /// This API is used to get the list of organization nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationNodesRequest"/></param>
        /// <returns><see cref="DescribeOrganizationNodesResponse"/></returns>
        public DescribeOrganizationNodesResponse DescribeOrganizationNodesSync(DescribeOrganizationNodesRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationNodesResponse>(req, "DescribeOrganizationNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of access identities of an organization member.
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationIdentityRequest"/></param>
        /// <returns><see cref="ListOrganizationIdentityResponse"/></returns>
        public Task<ListOrganizationIdentityResponse> ListOrganizationIdentity(ListOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<ListOrganizationIdentityResponse>(req, "ListOrganizationIdentity");
        }

        /// <summary>
        /// This API is used to get the list of access identities of an organization member.
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationIdentityRequest"/></param>
        /// <returns><see cref="ListOrganizationIdentityResponse"/></returns>
        public ListOrganizationIdentityResponse ListOrganizationIdentitySync(ListOrganizationIdentityRequest req)
        {
            return InternalRequestAsync<ListOrganizationIdentityResponse>(req, "ListOrganizationIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to move a member to the specified organization node.
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="MoveOrganizationNodeMembersResponse"/></returns>
        public Task<MoveOrganizationNodeMembersResponse> MoveOrganizationNodeMembers(MoveOrganizationNodeMembersRequest req)
        {
            return InternalRequestAsync<MoveOrganizationNodeMembersResponse>(req, "MoveOrganizationNodeMembers");
        }

        /// <summary>
        /// This API is used to move a member to the specified organization node.
        /// </summary>
        /// <param name="req"><see cref="MoveOrganizationNodeMembersRequest"/></param>
        /// <returns><see cref="MoveOrganizationNodeMembersResponse"/></returns>
        public MoveOrganizationNodeMembersResponse MoveOrganizationNodeMembersSync(MoveOrganizationNodeMembersRequest req)
        {
            return InternalRequestAsync<MoveOrganizationNodeMembersResponse>(req, "MoveOrganizationNodeMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update an organization node.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns><see cref="UpdateOrganizationNodeResponse"/></returns>
        public Task<UpdateOrganizationNodeResponse> UpdateOrganizationNode(UpdateOrganizationNodeRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationNodeResponse>(req, "UpdateOrganizationNode");
        }

        /// <summary>
        /// This API is used to update an organization node.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationNodeRequest"/></param>
        /// <returns><see cref="UpdateOrganizationNodeResponse"/></returns>
        public UpdateOrganizationNodeResponse UpdateOrganizationNodeSync(UpdateOrganizationNodeRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationNodeResponse>(req, "UpdateOrganizationNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
