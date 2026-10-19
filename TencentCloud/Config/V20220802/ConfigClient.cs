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

namespace TencentCloud.Config.V20220802
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Config.V20220802.Models;

   public class ConfigClient : AbstractClient{

       private const string endpoint = "config.intl.tencentcloudapi.com";
       private const string version = "2022-08-02";
       private const string sdkVersion = "SDK_NET_3.0.1409";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ConfigClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ConfigClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create compliance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="AddAggregateCompliancePackRequest"/></param>
        /// <returns><see cref="AddAggregateCompliancePackResponse"/></returns>
        public Task<AddAggregateCompliancePackResponse> AddAggregateCompliancePack(AddAggregateCompliancePackRequest req)
        {
            return InternalRequestAsync<AddAggregateCompliancePackResponse>(req, "AddAggregateCompliancePack");
        }

        /// <summary>
        /// This API is used to create compliance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="AddAggregateCompliancePackRequest"/></param>
        /// <returns><see cref="AddAggregateCompliancePackResponse"/></returns>
        public AddAggregateCompliancePackResponse AddAggregateCompliancePackSync(AddAggregateCompliancePackRequest req)
        {
            return InternalRequestAsync<AddAggregateCompliancePackResponse>(req, "AddAggregateCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create rules for account groups.
        /// </summary>
        /// <param name="req"><see cref="AddAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="AddAggregateConfigRuleResponse"/></returns>
        public Task<AddAggregateConfigRuleResponse> AddAggregateConfigRule(AddAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<AddAggregateConfigRuleResponse>(req, "AddAggregateConfigRule");
        }

        /// <summary>
        /// This API is used to create rules for account groups.
        /// </summary>
        /// <param name="req"><see cref="AddAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="AddAggregateConfigRuleResponse"/></returns>
        public AddAggregateConfigRuleResponse AddAggregateConfigRuleSync(AddAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<AddAggregateConfigRuleResponse>(req, "AddAggregateConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add alarm monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="AddAlarmPolicyRequest"/></param>
        /// <returns><see cref="AddAlarmPolicyResponse"/></returns>
        public Task<AddAlarmPolicyResponse> AddAlarmPolicy(AddAlarmPolicyRequest req)
        {
            return InternalRequestAsync<AddAlarmPolicyResponse>(req, "AddAlarmPolicy");
        }

        /// <summary>
        /// This API is used to add alarm monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="AddAlarmPolicyRequest"/></param>
        /// <returns><see cref="AddAlarmPolicyResponse"/></returns>
        public AddAlarmPolicyResponse AddAlarmPolicySync(AddAlarmPolicyRequest req)
        {
            return InternalRequestAsync<AddAlarmPolicyResponse>(req, "AddAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a compliance package.
        /// </summary>
        /// <param name="req"><see cref="AddCompliancePackRequest"/></param>
        /// <returns><see cref="AddCompliancePackResponse"/></returns>
        public Task<AddCompliancePackResponse> AddCompliancePack(AddCompliancePackRequest req)
        {
            return InternalRequestAsync<AddCompliancePackResponse>(req, "AddCompliancePack");
        }

        /// <summary>
        /// This API is used to create a compliance package.
        /// </summary>
        /// <param name="req"><see cref="AddCompliancePackRequest"/></param>
        /// <returns><see cref="AddCompliancePackResponse"/></returns>
        public AddCompliancePackResponse AddCompliancePackSync(AddCompliancePackRequest req)
        {
            return InternalRequestAsync<AddCompliancePackResponse>(req, "AddCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create rules.
        /// </summary>
        /// <param name="req"><see cref="AddConfigRuleRequest"/></param>
        /// <returns><see cref="AddConfigRuleResponse"/></returns>
        public Task<AddConfigRuleResponse> AddConfigRule(AddConfigRuleRequest req)
        {
            return InternalRequestAsync<AddConfigRuleResponse>(req, "AddConfigRule");
        }

        /// <summary>
        /// This API is used to create rules.
        /// </summary>
        /// <param name="req"><see cref="AddConfigRuleRequest"/></param>
        /// <returns><see cref="AddConfigRuleResponse"/></returns>
        public AddConfigRuleResponse AddConfigRuleSync(AddConfigRuleRequest req)
        {
            return InternalRequestAsync<AddConfigRuleResponse>(req, "AddConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to close rules for account groups.
        /// </summary>
        /// <param name="req"><see cref="CloseAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="CloseAggregateConfigRuleResponse"/></returns>
        public Task<CloseAggregateConfigRuleResponse> CloseAggregateConfigRule(CloseAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<CloseAggregateConfigRuleResponse>(req, "CloseAggregateConfigRule");
        }

        /// <summary>
        /// This API is used to close rules for account groups.
        /// </summary>
        /// <param name="req"><see cref="CloseAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="CloseAggregateConfigRuleResponse"/></returns>
        public CloseAggregateConfigRuleResponse CloseAggregateConfigRuleSync(CloseAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<CloseAggregateConfigRuleResponse>(req, "CloseAggregateConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manage resource monitoring - disabling monitoring.
        /// </summary>
        /// <param name="req"><see cref="CloseConfigRecorderRequest"/></param>
        /// <returns><see cref="CloseConfigRecorderResponse"/></returns>
        public Task<CloseConfigRecorderResponse> CloseConfigRecorder(CloseConfigRecorderRequest req)
        {
            return InternalRequestAsync<CloseConfigRecorderResponse>(req, "CloseConfigRecorder");
        }

        /// <summary>
        /// This API is used to manage resource monitoring - disabling monitoring.
        /// </summary>
        /// <param name="req"><see cref="CloseConfigRecorderRequest"/></param>
        /// <returns><see cref="CloseConfigRecorderResponse"/></returns>
        public CloseConfigRecorderResponse CloseConfigRecorderSync(CloseConfigRecorderRequest req)
        {
            return InternalRequestAsync<CloseConfigRecorderResponse>(req, "CloseConfigRecorder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Close rules
        /// </summary>
        /// <param name="req"><see cref="CloseConfigRuleRequest"/></param>
        /// <returns><see cref="CloseConfigRuleResponse"/></returns>
        public Task<CloseConfigRuleResponse> CloseConfigRule(CloseConfigRuleRequest req)
        {
            return InternalRequestAsync<CloseConfigRuleResponse>(req, "CloseConfigRule");
        }

        /// <summary>
        /// Close rules
        /// </summary>
        /// <param name="req"><see cref="CloseConfigRuleRequest"/></param>
        /// <returns><see cref="CloseConfigRuleResponse"/></returns>
        public CloseConfigRuleResponse CloseConfigRuleSync(CloseConfigRuleRequest req)
        {
            return InternalRequestAsync<CloseConfigRuleResponse>(req, "CloseConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create account groups.
        /// </summary>
        /// <param name="req"><see cref="CreateAggregatorRequest"/></param>
        /// <returns><see cref="CreateAggregatorResponse"/></returns>
        public Task<CreateAggregatorResponse> CreateAggregator(CreateAggregatorRequest req)
        {
            return InternalRequestAsync<CreateAggregatorResponse>(req, "CreateAggregator");
        }

        /// <summary>
        /// This API is used to create account groups.
        /// </summary>
        /// <param name="req"><see cref="CreateAggregatorRequest"/></param>
        /// <returns><see cref="CreateAggregatorResponse"/></returns>
        public CreateAggregatorResponse CreateAggregatorSync(CreateAggregatorRequest req)
        {
            return InternalRequestAsync<CreateAggregatorResponse>(req, "CreateAggregator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add rule remediation settings.
        /// </summary>
        /// <param name="req"><see cref="CreateRemediationRequest"/></param>
        /// <returns><see cref="CreateRemediationResponse"/></returns>
        public Task<CreateRemediationResponse> CreateRemediation(CreateRemediationRequest req)
        {
            return InternalRequestAsync<CreateRemediationResponse>(req, "CreateRemediation");
        }

        /// <summary>
        /// This API is used to add rule remediation settings.
        /// </summary>
        /// <param name="req"><see cref="CreateRemediationRequest"/></param>
        /// <returns><see cref="CreateRemediationResponse"/></returns>
        public CreateRemediationResponse CreateRemediationSync(CreateRemediationRequest req)
        {
            return InternalRequestAsync<CreateRemediationResponse>(req, "CreateRemediation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete compliance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteAggregateCompliancePackRequest"/></param>
        /// <returns><see cref="DeleteAggregateCompliancePackResponse"/></returns>
        public Task<DeleteAggregateCompliancePackResponse> DeleteAggregateCompliancePack(DeleteAggregateCompliancePackRequest req)
        {
            return InternalRequestAsync<DeleteAggregateCompliancePackResponse>(req, "DeleteAggregateCompliancePack");
        }

        /// <summary>
        /// This API is used to delete compliance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteAggregateCompliancePackRequest"/></param>
        /// <returns><see cref="DeleteAggregateCompliancePackResponse"/></returns>
        public DeleteAggregateCompliancePackResponse DeleteAggregateCompliancePackSync(DeleteAggregateCompliancePackRequest req)
        {
            return InternalRequestAsync<DeleteAggregateCompliancePackResponse>(req, "DeleteAggregateCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete rules for account groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="DeleteAggregateConfigRuleResponse"/></returns>
        public Task<DeleteAggregateConfigRuleResponse> DeleteAggregateConfigRule(DeleteAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<DeleteAggregateConfigRuleResponse>(req, "DeleteAggregateConfigRule");
        }

        /// <summary>
        /// This API is used to delete rules for account groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="DeleteAggregateConfigRuleResponse"/></returns>
        public DeleteAggregateConfigRuleResponse DeleteAggregateConfigRuleSync(DeleteAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<DeleteAggregateConfigRuleResponse>(req, "DeleteAggregateConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete account groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteAggregatorsRequest"/></param>
        /// <returns><see cref="DeleteAggregatorsResponse"/></returns>
        public Task<DeleteAggregatorsResponse> DeleteAggregators(DeleteAggregatorsRequest req)
        {
            return InternalRequestAsync<DeleteAggregatorsResponse>(req, "DeleteAggregators");
        }

        /// <summary>
        /// This API is used to delete account groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteAggregatorsRequest"/></param>
        /// <returns><see cref="DeleteAggregatorsResponse"/></returns>
        public DeleteAggregatorsResponse DeleteAggregatorsSync(DeleteAggregatorsRequest req)
        {
            return InternalRequestAsync<DeleteAggregatorsResponse>(req, "DeleteAggregators")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes alarm rules
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmPolicyRequest"/></param>
        /// <returns><see cref="DeleteAlarmPolicyResponse"/></returns>
        public Task<DeleteAlarmPolicyResponse> DeleteAlarmPolicy(DeleteAlarmPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAlarmPolicyResponse>(req, "DeleteAlarmPolicy");
        }

        /// <summary>
        /// Deletes alarm rules
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmPolicyRequest"/></param>
        /// <returns><see cref="DeleteAlarmPolicyResponse"/></returns>
        public DeleteAlarmPolicyResponse DeleteAlarmPolicySync(DeleteAlarmPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAlarmPolicyResponse>(req, "DeleteAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete compliance packages.
        /// </summary>
        /// <param name="req"><see cref="DeleteCompliancePackRequest"/></param>
        /// <returns><see cref="DeleteCompliancePackResponse"/></returns>
        public Task<DeleteCompliancePackResponse> DeleteCompliancePack(DeleteCompliancePackRequest req)
        {
            return InternalRequestAsync<DeleteCompliancePackResponse>(req, "DeleteCompliancePack");
        }

        /// <summary>
        /// This API is used to delete compliance packages.
        /// </summary>
        /// <param name="req"><see cref="DeleteCompliancePackRequest"/></param>
        /// <returns><see cref="DeleteCompliancePackResponse"/></returns>
        public DeleteCompliancePackResponse DeleteCompliancePackSync(DeleteCompliancePackRequest req)
        {
            return InternalRequestAsync<DeleteCompliancePackResponse>(req, "DeleteCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a rule
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRuleRequest"/></param>
        /// <returns><see cref="DeleteConfigRuleResponse"/></returns>
        public Task<DeleteConfigRuleResponse> DeleteConfigRule(DeleteConfigRuleRequest req)
        {
            return InternalRequestAsync<DeleteConfigRuleResponse>(req, "DeleteConfigRule");
        }

        /// <summary>
        /// Delete a rule
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRuleRequest"/></param>
        /// <returns><see cref="DeleteConfigRuleResponse"/></returns>
        public DeleteConfigRuleResponse DeleteConfigRuleSync(DeleteConfigRuleRequest req)
        {
            return InternalRequestAsync<DeleteConfigRuleResponse>(req, "DeleteConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete rule remediation settings.
        /// </summary>
        /// <param name="req"><see cref="DeleteRemediationsRequest"/></param>
        /// <returns><see cref="DeleteRemediationsResponse"/></returns>
        public Task<DeleteRemediationsResponse> DeleteRemediations(DeleteRemediationsRequest req)
        {
            return InternalRequestAsync<DeleteRemediationsResponse>(req, "DeleteRemediations");
        }

        /// <summary>
        /// This API is used to delete rule remediation settings.
        /// </summary>
        /// <param name="req"><see cref="DeleteRemediationsRequest"/></param>
        /// <returns><see cref="DeleteRemediationsResponse"/></returns>
        public DeleteRemediationsResponse DeleteRemediationsSync(DeleteRemediationsRequest req)
        {
            return InternalRequestAsync<DeleteRemediationsResponse>(req, "DeleteRemediations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query compliance package details for account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAggregateCompliancePackRequest"/></param>
        /// <returns><see cref="DescribeAggregateCompliancePackResponse"/></returns>
        public Task<DescribeAggregateCompliancePackResponse> DescribeAggregateCompliancePack(DescribeAggregateCompliancePackRequest req)
        {
            return InternalRequestAsync<DescribeAggregateCompliancePackResponse>(req, "DescribeAggregateCompliancePack");
        }

        /// <summary>
        /// This API is used to query compliance package details for account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAggregateCompliancePackRequest"/></param>
        /// <returns><see cref="DescribeAggregateCompliancePackResponse"/></returns>
        public DescribeAggregateCompliancePackResponse DescribeAggregateCompliancePackSync(DescribeAggregateCompliancePackRequest req)
        {
            return InternalRequestAsync<DescribeAggregateCompliancePackResponse>(req, "DescribeAggregateCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query delivery setting details for account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAggregateConfigDeliverRequest"/></param>
        /// <returns><see cref="DescribeAggregateConfigDeliverResponse"/></returns>
        public Task<DescribeAggregateConfigDeliverResponse> DescribeAggregateConfigDeliver(DescribeAggregateConfigDeliverRequest req)
        {
            return InternalRequestAsync<DescribeAggregateConfigDeliverResponse>(req, "DescribeAggregateConfigDeliver");
        }

        /// <summary>
        /// This API is used to query delivery setting details for account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAggregateConfigDeliverRequest"/></param>
        /// <returns><see cref="DescribeAggregateConfigDeliverResponse"/></returns>
        public DescribeAggregateConfigDeliverResponse DescribeAggregateConfigDeliverSync(DescribeAggregateConfigDeliverRequest req)
        {
            return InternalRequestAsync<DescribeAggregateConfigDeliverResponse>(req, "DescribeAggregateConfigDeliver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query rule details for account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="DescribeAggregateConfigRuleResponse"/></returns>
        public Task<DescribeAggregateConfigRuleResponse> DescribeAggregateConfigRule(DescribeAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<DescribeAggregateConfigRuleResponse>(req, "DescribeAggregateConfigRule");
        }

        /// <summary>
        /// This API is used to query rule details for account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="DescribeAggregateConfigRuleResponse"/></returns>
        public DescribeAggregateConfigRuleResponse DescribeAggregateConfigRuleSync(DescribeAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<DescribeAggregateConfigRuleResponse>(req, "DescribeAggregateConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query resource details for account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAggregateDiscoveredResourceRequest"/></param>
        /// <returns><see cref="DescribeAggregateDiscoveredResourceResponse"/></returns>
        public Task<DescribeAggregateDiscoveredResourceResponse> DescribeAggregateDiscoveredResource(DescribeAggregateDiscoveredResourceRequest req)
        {
            return InternalRequestAsync<DescribeAggregateDiscoveredResourceResponse>(req, "DescribeAggregateDiscoveredResource");
        }

        /// <summary>
        /// This API is used to query resource details for account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAggregateDiscoveredResourceRequest"/></param>
        /// <returns><see cref="DescribeAggregateDiscoveredResourceResponse"/></returns>
        public DescribeAggregateDiscoveredResourceResponse DescribeAggregateDiscoveredResourceSync(DescribeAggregateDiscoveredResourceRequest req)
        {
            return InternalRequestAsync<DescribeAggregateDiscoveredResourceResponse>(req, "DescribeAggregateDiscoveredResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This example shows you how to query account group details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAggregatorRequest"/></param>
        /// <returns><see cref="DescribeAggregatorResponse"/></returns>
        public Task<DescribeAggregatorResponse> DescribeAggregator(DescribeAggregatorRequest req)
        {
            return InternalRequestAsync<DescribeAggregatorResponse>(req, "DescribeAggregator");
        }

        /// <summary>
        /// This example shows you how to query account group details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAggregatorRequest"/></param>
        /// <returns><see cref="DescribeAggregatorResponse"/></returns>
        public DescribeAggregatorResponse DescribeAggregatorSync(DescribeAggregatorRequest req)
        {
            return InternalRequestAsync<DescribeAggregatorResponse>(req, "DescribeAggregator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query compliance package details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePackRequest"/></param>
        /// <returns><see cref="DescribeCompliancePackResponse"/></returns>
        public Task<DescribeCompliancePackResponse> DescribeCompliancePack(DescribeCompliancePackRequest req)
        {
            return InternalRequestAsync<DescribeCompliancePackResponse>(req, "DescribeCompliancePack");
        }

        /// <summary>
        /// This API is used to query compliance package details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePackRequest"/></param>
        /// <returns><see cref="DescribeCompliancePackResponse"/></returns>
        public DescribeCompliancePackResponse DescribeCompliancePackSync(DescribeCompliancePackRequest req)
        {
            return InternalRequestAsync<DescribeCompliancePackResponse>(req, "DescribeCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query delivery setting details.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDeliverRequest"/></param>
        /// <returns><see cref="DescribeConfigDeliverResponse"/></returns>
        public Task<DescribeConfigDeliverResponse> DescribeConfigDeliver(DescribeConfigDeliverRequest req)
        {
            return InternalRequestAsync<DescribeConfigDeliverResponse>(req, "DescribeConfigDeliver");
        }

        /// <summary>
        /// This API is used to query delivery setting details.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigDeliverRequest"/></param>
        /// <returns><see cref="DescribeConfigDeliverResponse"/></returns>
        public DescribeConfigDeliverResponse DescribeConfigDeliverSync(DescribeConfigDeliverRequest req)
        {
            return InternalRequestAsync<DescribeConfigDeliverResponse>(req, "DescribeConfigDeliver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query monitoring details.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRecorderRequest"/></param>
        /// <returns><see cref="DescribeConfigRecorderResponse"/></returns>
        public Task<DescribeConfigRecorderResponse> DescribeConfigRecorder(DescribeConfigRecorderRequest req)
        {
            return InternalRequestAsync<DescribeConfigRecorderResponse>(req, "DescribeConfigRecorder");
        }

        /// <summary>
        /// This API is used to query monitoring details.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRecorderRequest"/></param>
        /// <returns><see cref="DescribeConfigRecorderResponse"/></returns>
        public DescribeConfigRecorderResponse DescribeConfigRecorderSync(DescribeConfigRecorderRequest req)
        {
            return InternalRequestAsync<DescribeConfigRecorderResponse>(req, "DescribeConfigRecorder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This example shows you how to query rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRuleRequest"/></param>
        /// <returns><see cref="DescribeConfigRuleResponse"/></returns>
        public Task<DescribeConfigRuleResponse> DescribeConfigRule(DescribeConfigRuleRequest req)
        {
            return InternalRequestAsync<DescribeConfigRuleResponse>(req, "DescribeConfigRule");
        }

        /// <summary>
        /// This example shows you how to query rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigRuleRequest"/></param>
        /// <returns><see cref="DescribeConfigRuleResponse"/></returns>
        public DescribeConfigRuleResponse DescribeConfigRuleSync(DescribeConfigRuleRequest req)
        {
            return InternalRequestAsync<DescribeConfigRuleResponse>(req, "DescribeConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Resource details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiscoveredResourceRequest"/></param>
        /// <returns><see cref="DescribeDiscoveredResourceResponse"/></returns>
        public Task<DescribeDiscoveredResourceResponse> DescribeDiscoveredResource(DescribeDiscoveredResourceRequest req)
        {
            return InternalRequestAsync<DescribeDiscoveredResourceResponse>(req, "DescribeDiscoveredResource");
        }

        /// <summary>
        /// Resource details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiscoveredResourceRequest"/></param>
        /// <returns><see cref="DescribeDiscoveredResourceResponse"/></returns>
        public DescribeDiscoveredResourceResponse DescribeDiscoveredResourceSync(DescribeDiscoveredResourceRequest req)
        {
            return InternalRequestAsync<DescribeDiscoveredResourceResponse>(req, "DescribeDiscoveredResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the system compliance package details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemCompliancePackRequest"/></param>
        /// <returns><see cref="DescribeSystemCompliancePackResponse"/></returns>
        public Task<DescribeSystemCompliancePackResponse> DescribeSystemCompliancePack(DescribeSystemCompliancePackRequest req)
        {
            return InternalRequestAsync<DescribeSystemCompliancePackResponse>(req, "DescribeSystemCompliancePack");
        }

        /// <summary>
        /// This API is used to query the system compliance package details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemCompliancePackRequest"/></param>
        /// <returns><see cref="DescribeSystemCompliancePackResponse"/></returns>
        public DescribeSystemCompliancePackResponse DescribeSystemCompliancePackSync(DescribeSystemCompliancePackRequest req)
        {
            return InternalRequestAsync<DescribeSystemCompliancePackResponse>(req, "DescribeSystemCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to preset rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemRuleRequest"/></param>
        /// <returns><see cref="DescribeSystemRuleResponse"/></returns>
        public Task<DescribeSystemRuleResponse> DescribeSystemRule(DescribeSystemRuleRequest req)
        {
            return InternalRequestAsync<DescribeSystemRuleResponse>(req, "DescribeSystemRule");
        }

        /// <summary>
        /// This API is used to preset rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemRuleRequest"/></param>
        /// <returns><see cref="DescribeSystemRuleResponse"/></returns>
        public DescribeSystemRuleResponse DescribeSystemRuleSync(DescribeSystemRuleRequest req)
        {
            return InternalRequestAsync<DescribeSystemRuleResponse>(req, "DescribeSystemRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove rules from compliance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="DetachAggregateConfigRuleToCompliancePackRequest"/></param>
        /// <returns><see cref="DetachAggregateConfigRuleToCompliancePackResponse"/></returns>
        public Task<DetachAggregateConfigRuleToCompliancePackResponse> DetachAggregateConfigRuleToCompliancePack(DetachAggregateConfigRuleToCompliancePackRequest req)
        {
            return InternalRequestAsync<DetachAggregateConfigRuleToCompliancePackResponse>(req, "DetachAggregateConfigRuleToCompliancePack");
        }

        /// <summary>
        /// This API is used to remove rules from compliance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="DetachAggregateConfigRuleToCompliancePackRequest"/></param>
        /// <returns><see cref="DetachAggregateConfigRuleToCompliancePackResponse"/></returns>
        public DetachAggregateConfigRuleToCompliancePackResponse DetachAggregateConfigRuleToCompliancePackSync(DetachAggregateConfigRuleToCompliancePackRequest req)
        {
            return InternalRequestAsync<DetachAggregateConfigRuleToCompliancePackResponse>(req, "DetachAggregateConfigRuleToCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove rules for a compliance package.
        /// </summary>
        /// <param name="req"><see cref="DetachConfigRuleToCompliancePackRequest"/></param>
        /// <returns><see cref="DetachConfigRuleToCompliancePackResponse"/></returns>
        public Task<DetachConfigRuleToCompliancePackResponse> DetachConfigRuleToCompliancePack(DetachConfigRuleToCompliancePackRequest req)
        {
            return InternalRequestAsync<DetachConfigRuleToCompliancePackResponse>(req, "DetachConfigRuleToCompliancePack");
        }

        /// <summary>
        /// This API is used to remove rules for a compliance package.
        /// </summary>
        /// <param name="req"><see cref="DetachConfigRuleToCompliancePackRequest"/></param>
        /// <returns><see cref="DetachConfigRuleToCompliancePackResponse"/></returns>
        public DetachConfigRuleToCompliancePackResponse DetachConfigRuleToCompliancePackSync(DetachConfigRuleToCompliancePackRequest req)
        {
            return InternalRequestAsync<DetachConfigRuleToCompliancePackResponse>(req, "DetachConfigRuleToCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of compliance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateCompliancePacksRequest"/></param>
        /// <returns><see cref="ListAggregateCompliancePacksResponse"/></returns>
        public Task<ListAggregateCompliancePacksResponse> ListAggregateCompliancePacks(ListAggregateCompliancePacksRequest req)
        {
            return InternalRequestAsync<ListAggregateCompliancePacksResponse>(req, "ListAggregateCompliancePacks");
        }

        /// <summary>
        /// This API is used to query the list of compliance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateCompliancePacksRequest"/></param>
        /// <returns><see cref="ListAggregateCompliancePacksResponse"/></returns>
        public ListAggregateCompliancePacksResponse ListAggregateCompliancePacksSync(ListAggregateCompliancePacksRequest req)
        {
            return InternalRequestAsync<ListAggregateCompliancePacksResponse>(req, "ListAggregateCompliancePacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query evaluation results from the rule dimension for account groups (the list of evaluation results for resources under a specific rule).
        /// </summary>
        /// <param name="req"><see cref="ListAggregateConfigRuleEvaluationResultsRequest"/></param>
        /// <returns><see cref="ListAggregateConfigRuleEvaluationResultsResponse"/></returns>
        public Task<ListAggregateConfigRuleEvaluationResultsResponse> ListAggregateConfigRuleEvaluationResults(ListAggregateConfigRuleEvaluationResultsRequest req)
        {
            return InternalRequestAsync<ListAggregateConfigRuleEvaluationResultsResponse>(req, "ListAggregateConfigRuleEvaluationResults");
        }

        /// <summary>
        /// This API is used to query evaluation results from the rule dimension for account groups (the list of evaluation results for resources under a specific rule).
        /// </summary>
        /// <param name="req"><see cref="ListAggregateConfigRuleEvaluationResultsRequest"/></param>
        /// <returns><see cref="ListAggregateConfigRuleEvaluationResultsResponse"/></returns>
        public ListAggregateConfigRuleEvaluationResultsResponse ListAggregateConfigRuleEvaluationResultsSync(ListAggregateConfigRuleEvaluationResultsRequest req)
        {
            return InternalRequestAsync<ListAggregateConfigRuleEvaluationResultsResponse>(req, "ListAggregateConfigRuleEvaluationResults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list resource evaluation results of compliance rules in account groups.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateConfigRuleResourceEvaluationResultsRequest"/></param>
        /// <returns><see cref="ListAggregateConfigRuleResourceEvaluationResultsResponse"/></returns>
        public Task<ListAggregateConfigRuleResourceEvaluationResultsResponse> ListAggregateConfigRuleResourceEvaluationResults(ListAggregateConfigRuleResourceEvaluationResultsRequest req)
        {
            return InternalRequestAsync<ListAggregateConfigRuleResourceEvaluationResultsResponse>(req, "ListAggregateConfigRuleResourceEvaluationResults");
        }

        /// <summary>
        /// This API is used to list resource evaluation results of compliance rules in account groups.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateConfigRuleResourceEvaluationResultsRequest"/></param>
        /// <returns><see cref="ListAggregateConfigRuleResourceEvaluationResultsResponse"/></returns>
        public ListAggregateConfigRuleResourceEvaluationResultsResponse ListAggregateConfigRuleResourceEvaluationResultsSync(ListAggregateConfigRuleResourceEvaluationResultsRequest req)
        {
            return InternalRequestAsync<ListAggregateConfigRuleResourceEvaluationResultsResponse>(req, "ListAggregateConfigRuleResourceEvaluationResults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of rules for account groups.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateConfigRulesRequest"/></param>
        /// <returns><see cref="ListAggregateConfigRulesResponse"/></returns>
        public Task<ListAggregateConfigRulesResponse> ListAggregateConfigRules(ListAggregateConfigRulesRequest req)
        {
            return InternalRequestAsync<ListAggregateConfigRulesResponse>(req, "ListAggregateConfigRules");
        }

        /// <summary>
        /// This API is used to query the list of rules for account groups.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateConfigRulesRequest"/></param>
        /// <returns><see cref="ListAggregateConfigRulesResponse"/></returns>
        public ListAggregateConfigRulesResponse ListAggregateConfigRulesSync(ListAggregateConfigRulesRequest req)
        {
            return InternalRequestAsync<ListAggregateConfigRulesResponse>(req, "ListAggregateConfigRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of resources for account groups.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateDiscoveredResourcesRequest"/></param>
        /// <returns><see cref="ListAggregateDiscoveredResourcesResponse"/></returns>
        public Task<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest req)
        {
            return InternalRequestAsync<ListAggregateDiscoveredResourcesResponse>(req, "ListAggregateDiscoveredResources");
        }

        /// <summary>
        /// This API is used to query the list of resources for account groups.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateDiscoveredResourcesRequest"/></param>
        /// <returns><see cref="ListAggregateDiscoveredResourcesResponse"/></returns>
        public ListAggregateDiscoveredResourcesResponse ListAggregateDiscoveredResourcesSync(ListAggregateDiscoveredResourcesRequest req)
        {
            return InternalRequestAsync<ListAggregateDiscoveredResourcesResponse>(req, "ListAggregateDiscoveredResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Account group list.
        /// </summary>
        /// <param name="req"><see cref="ListAggregatorsRequest"/></param>
        /// <returns><see cref="ListAggregatorsResponse"/></returns>
        public Task<ListAggregatorsResponse> ListAggregators(ListAggregatorsRequest req)
        {
            return InternalRequestAsync<ListAggregatorsResponse>(req, "ListAggregators");
        }

        /// <summary>
        /// Account group list.
        /// </summary>
        /// <param name="req"><see cref="ListAggregatorsRequest"/></param>
        /// <returns><see cref="ListAggregatorsResponse"/></returns>
        public ListAggregatorsResponse ListAggregatorsSync(ListAggregatorsRequest req)
        {
            return InternalRequestAsync<ListAggregatorsResponse>(req, "ListAggregators")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Alarm rule list
        /// </summary>
        /// <param name="req"><see cref="ListAlarmPolicyRequest"/></param>
        /// <returns><see cref="ListAlarmPolicyResponse"/></returns>
        public Task<ListAlarmPolicyResponse> ListAlarmPolicy(ListAlarmPolicyRequest req)
        {
            return InternalRequestAsync<ListAlarmPolicyResponse>(req, "ListAlarmPolicy");
        }

        /// <summary>
        /// Alarm rule list
        /// </summary>
        /// <param name="req"><see cref="ListAlarmPolicyRequest"/></param>
        /// <returns><see cref="ListAlarmPolicyResponse"/></returns>
        public ListAlarmPolicyResponse ListAlarmPolicySync(ListAlarmPolicyRequest req)
        {
            return InternalRequestAsync<ListAlarmPolicyResponse>(req, "ListAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of compliance packages.
        /// </summary>
        /// <param name="req"><see cref="ListCompliancePacksRequest"/></param>
        /// <returns><see cref="ListCompliancePacksResponse"/></returns>
        public Task<ListCompliancePacksResponse> ListCompliancePacks(ListCompliancePacksRequest req)
        {
            return InternalRequestAsync<ListCompliancePacksResponse>(req, "ListCompliancePacks");
        }

        /// <summary>
        /// This API is used to query the list of compliance packages.
        /// </summary>
        /// <param name="req"><see cref="ListCompliancePacksRequest"/></param>
        /// <returns><see cref="ListCompliancePacksResponse"/></returns>
        public ListCompliancePacksResponse ListCompliancePacksSync(ListCompliancePacksRequest req)
        {
            return InternalRequestAsync<ListCompliancePacksResponse>(req, "ListCompliancePacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  This API is used to obtain evaluation results from the rule dimension (the list of evaluation results for resources under a specific rule).
        /// </summary>
        /// <param name="req"><see cref="ListConfigRuleEvaluationResultsRequest"/></param>
        /// <returns><see cref="ListConfigRuleEvaluationResultsResponse"/></returns>
        public Task<ListConfigRuleEvaluationResultsResponse> ListConfigRuleEvaluationResults(ListConfigRuleEvaluationResultsRequest req)
        {
            return InternalRequestAsync<ListConfigRuleEvaluationResultsResponse>(req, "ListConfigRuleEvaluationResults");
        }

        /// <summary>
        ///  This API is used to obtain evaluation results from the rule dimension (the list of evaluation results for resources under a specific rule).
        /// </summary>
        /// <param name="req"><see cref="ListConfigRuleEvaluationResultsRequest"/></param>
        /// <returns><see cref="ListConfigRuleEvaluationResultsResponse"/></returns>
        public ListConfigRuleEvaluationResultsResponse ListConfigRuleEvaluationResultsSync(ListConfigRuleEvaluationResultsRequest req)
        {
            return InternalRequestAsync<ListConfigRuleEvaluationResultsResponse>(req, "ListConfigRuleEvaluationResults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of resource evaluation results under configuration rules.
        /// </summary>
        /// <param name="req"><see cref="ListConfigRuleResourceEvaluationResultsRequest"/></param>
        /// <returns><see cref="ListConfigRuleResourceEvaluationResultsResponse"/></returns>
        public Task<ListConfigRuleResourceEvaluationResultsResponse> ListConfigRuleResourceEvaluationResults(ListConfigRuleResourceEvaluationResultsRequest req)
        {
            return InternalRequestAsync<ListConfigRuleResourceEvaluationResultsResponse>(req, "ListConfigRuleResourceEvaluationResults");
        }

        /// <summary>
        /// This API is used to query the list of resource evaluation results under configuration rules.
        /// </summary>
        /// <param name="req"><see cref="ListConfigRuleResourceEvaluationResultsRequest"/></param>
        /// <returns><see cref="ListConfigRuleResourceEvaluationResultsResponse"/></returns>
        public ListConfigRuleResourceEvaluationResultsResponse ListConfigRuleResourceEvaluationResultsSync(ListConfigRuleResourceEvaluationResultsRequest req)
        {
            return InternalRequestAsync<ListConfigRuleResourceEvaluationResultsResponse>(req, "ListConfigRuleResourceEvaluationResults")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This example shows you how to query the rule list.
        /// </summary>
        /// <param name="req"><see cref="ListConfigRulesRequest"/></param>
        /// <returns><see cref="ListConfigRulesResponse"/></returns>
        public Task<ListConfigRulesResponse> ListConfigRules(ListConfigRulesRequest req)
        {
            return InternalRequestAsync<ListConfigRulesResponse>(req, "ListConfigRules");
        }

        /// <summary>
        /// This example shows you how to query the rule list.
        /// </summary>
        /// <param name="req"><see cref="ListConfigRulesRequest"/></param>
        /// <returns><see cref="ListConfigRulesResponse"/></returns>
        public ListConfigRulesResponse ListConfigRulesSync(ListConfigRulesRequest req)
        {
            return InternalRequestAsync<ListConfigRulesResponse>(req, "ListConfigRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtaining the Resource List
        /// </summary>
        /// <param name="req"><see cref="ListDiscoveredResourcesRequest"/></param>
        /// <returns><see cref="ListDiscoveredResourcesResponse"/></returns>
        public Task<ListDiscoveredResourcesResponse> ListDiscoveredResources(ListDiscoveredResourcesRequest req)
        {
            return InternalRequestAsync<ListDiscoveredResourcesResponse>(req, "ListDiscoveredResources");
        }

        /// <summary>
        /// Obtaining the Resource List
        /// </summary>
        /// <param name="req"><see cref="ListDiscoveredResourcesRequest"/></param>
        /// <returns><see cref="ListDiscoveredResourcesResponse"/></returns>
        public ListDiscoveredResourcesResponse ListDiscoveredResourcesSync(ListDiscoveredResourcesRequest req)
        {
            return InternalRequestAsync<ListDiscoveredResourcesResponse>(req, "ListDiscoveredResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Correction records.
        /// </summary>
        /// <param name="req"><see cref="ListRemediationExecutionsRequest"/></param>
        /// <returns><see cref="ListRemediationExecutionsResponse"/></returns>
        public Task<ListRemediationExecutionsResponse> ListRemediationExecutions(ListRemediationExecutionsRequest req)
        {
            return InternalRequestAsync<ListRemediationExecutionsResponse>(req, "ListRemediationExecutions");
        }

        /// <summary>
        /// Correction records.
        /// </summary>
        /// <param name="req"><see cref="ListRemediationExecutionsRequest"/></param>
        /// <returns><see cref="ListRemediationExecutionsResponse"/></returns>
        public ListRemediationExecutionsResponse ListRemediationExecutionsSync(ListRemediationExecutionsRequest req)
        {
            return InternalRequestAsync<ListRemediationExecutionsResponse>(req, "ListRemediationExecutions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list remediation settings.
        /// </summary>
        /// <param name="req"><see cref="ListRemediationsRequest"/></param>
        /// <returns><see cref="ListRemediationsResponse"/></returns>
        public Task<ListRemediationsResponse> ListRemediations(ListRemediationsRequest req)
        {
            return InternalRequestAsync<ListRemediationsResponse>(req, "ListRemediations");
        }

        /// <summary>
        /// This API is used to list remediation settings.
        /// </summary>
        /// <param name="req"><see cref="ListRemediationsRequest"/></param>
        /// <returns><see cref="ListRemediationsResponse"/></returns>
        public ListRemediationsResponse ListRemediationsSync(ListRemediationsRequest req)
        {
            return InternalRequestAsync<ListRemediationsResponse>(req, "ListRemediations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the resource type list.
        /// </summary>
        /// <param name="req"><see cref="ListResourceTypesRequest"/></param>
        /// <returns><see cref="ListResourceTypesResponse"/></returns>
        public Task<ListResourceTypesResponse> ListResourceTypes(ListResourceTypesRequest req)
        {
            return InternalRequestAsync<ListResourceTypesResponse>(req, "ListResourceTypes");
        }

        /// <summary>
        /// This API is used to query the resource type list.
        /// </summary>
        /// <param name="req"><see cref="ListResourceTypesRequest"/></param>
        /// <returns><see cref="ListResourceTypesResponse"/></returns>
        public ListResourceTypesResponse ListResourceTypesSync(ListResourceTypesRequest req)
        {
            return InternalRequestAsync<ListResourceTypesResponse>(req, "ListResourceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of system compliance packages.
        /// </summary>
        /// <param name="req"><see cref="ListSystemCompliancePacksRequest"/></param>
        /// <returns><see cref="ListSystemCompliancePacksResponse"/></returns>
        public Task<ListSystemCompliancePacksResponse> ListSystemCompliancePacks(ListSystemCompliancePacksRequest req)
        {
            return InternalRequestAsync<ListSystemCompliancePacksResponse>(req, "ListSystemCompliancePacks");
        }

        /// <summary>
        /// This API is used to query the list of system compliance packages.
        /// </summary>
        /// <param name="req"><see cref="ListSystemCompliancePacksRequest"/></param>
        /// <returns><see cref="ListSystemCompliancePacksResponse"/></returns>
        public ListSystemCompliancePacksResponse ListSystemCompliancePacksSync(ListSystemCompliancePacksRequest req)
        {
            return InternalRequestAsync<ListSystemCompliancePacksResponse>(req, "ListSystemCompliancePacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the preset rule list.
        /// </summary>
        /// <param name="req"><see cref="ListSystemRulesRequest"/></param>
        /// <returns><see cref="ListSystemRulesResponse"/></returns>
        public Task<ListSystemRulesResponse> ListSystemRules(ListSystemRulesRequest req)
        {
            return InternalRequestAsync<ListSystemRulesResponse>(req, "ListSystemRules");
        }

        /// <summary>
        /// This API is used to query the preset rule list.
        /// </summary>
        /// <param name="req"><see cref="ListSystemRulesRequest"/></param>
        /// <returns><see cref="ListSystemRulesResponse"/></returns>
        public ListSystemRulesResponse ListSystemRulesSync(ListSystemRulesRequest req)
        {
            return InternalRequestAsync<ListSystemRulesResponse>(req, "ListSystemRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a rule for an account group.
        /// </summary>
        /// <param name="req"><see cref="OpenAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="OpenAggregateConfigRuleResponse"/></returns>
        public Task<OpenAggregateConfigRuleResponse> OpenAggregateConfigRule(OpenAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<OpenAggregateConfigRuleResponse>(req, "OpenAggregateConfigRule");
        }

        /// <summary>
        /// This API is used to enable a rule for an account group.
        /// </summary>
        /// <param name="req"><see cref="OpenAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="OpenAggregateConfigRuleResponse"/></returns>
        public OpenAggregateConfigRuleResponse OpenAggregateConfigRuleSync(OpenAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<OpenAggregateConfigRuleResponse>(req, "OpenAggregateConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manage resource monitoring - enabling monitoring.
        /// </summary>
        /// <param name="req"><see cref="OpenConfigRecorderRequest"/></param>
        /// <returns><see cref="OpenConfigRecorderResponse"/></returns>
        public Task<OpenConfigRecorderResponse> OpenConfigRecorder(OpenConfigRecorderRequest req)
        {
            return InternalRequestAsync<OpenConfigRecorderResponse>(req, "OpenConfigRecorder");
        }

        /// <summary>
        /// This API is used to manage resource monitoring - enabling monitoring.
        /// </summary>
        /// <param name="req"><see cref="OpenConfigRecorderRequest"/></param>
        /// <returns><see cref="OpenConfigRecorderResponse"/></returns>
        public OpenConfigRecorderResponse OpenConfigRecorderSync(OpenConfigRecorderRequest req)
        {
            return InternalRequestAsync<OpenConfigRecorderResponse>(req, "OpenConfigRecorder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Enable rules
        /// </summary>
        /// <param name="req"><see cref="OpenConfigRuleRequest"/></param>
        /// <returns><see cref="OpenConfigRuleResponse"/></returns>
        public Task<OpenConfigRuleResponse> OpenConfigRule(OpenConfigRuleRequest req)
        {
            return InternalRequestAsync<OpenConfigRuleResponse>(req, "OpenConfigRule");
        }

        /// <summary>
        /// Enable rules
        /// </summary>
        /// <param name="req"><see cref="OpenConfigRuleRequest"/></param>
        /// <returns><see cref="OpenConfigRuleResponse"/></returns>
        public OpenConfigRuleResponse OpenConfigRuleSync(OpenConfigRuleRequest req)
        {
            return InternalRequestAsync<OpenConfigRuleResponse>(req, "OpenConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Reporting Evaluation Results Under Custom Rules
        /// </summary>
        /// <param name="req"><see cref="PutEvaluationsRequest"/></param>
        /// <returns><see cref="PutEvaluationsResponse"/></returns>
        public Task<PutEvaluationsResponse> PutEvaluations(PutEvaluationsRequest req)
        {
            return InternalRequestAsync<PutEvaluationsResponse>(req, "PutEvaluations");
        }

        /// <summary>
        /// Reporting Evaluation Results Under Custom Rules
        /// </summary>
        /// <param name="req"><see cref="PutEvaluationsRequest"/></param>
        /// <returns><see cref="PutEvaluationsResponse"/></returns>
        public PutEvaluationsResponse PutEvaluationsSync(PutEvaluationsRequest req)
        {
            return InternalRequestAsync<PutEvaluationsResponse>(req, "PutEvaluations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to trigger evaluation for account groups.
        /// </summary>
        /// <param name="req"><see cref="StartAggregateConfigRuleEvaluationRequest"/></param>
        /// <returns><see cref="StartAggregateConfigRuleEvaluationResponse"/></returns>
        public Task<StartAggregateConfigRuleEvaluationResponse> StartAggregateConfigRuleEvaluation(StartAggregateConfigRuleEvaluationRequest req)
        {
            return InternalRequestAsync<StartAggregateConfigRuleEvaluationResponse>(req, "StartAggregateConfigRuleEvaluation");
        }

        /// <summary>
        /// This API is used to trigger evaluation for account groups.
        /// </summary>
        /// <param name="req"><see cref="StartAggregateConfigRuleEvaluationRequest"/></param>
        /// <returns><see cref="StartAggregateConfigRuleEvaluationResponse"/></returns>
        public StartAggregateConfigRuleEvaluationResponse StartAggregateConfigRuleEvaluationSync(StartAggregateConfigRuleEvaluationRequest req)
        {
            return InternalRequestAsync<StartAggregateConfigRuleEvaluationResponse>(req, "StartAggregateConfigRuleEvaluation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to trigger evaluations.
        /// </summary>
        /// <param name="req"><see cref="StartConfigRuleEvaluationRequest"/></param>
        /// <returns><see cref="StartConfigRuleEvaluationResponse"/></returns>
        public Task<StartConfigRuleEvaluationResponse> StartConfigRuleEvaluation(StartConfigRuleEvaluationRequest req)
        {
            return InternalRequestAsync<StartConfigRuleEvaluationResponse>(req, "StartConfigRuleEvaluation");
        }

        /// <summary>
        /// This API is used to trigger evaluations.
        /// </summary>
        /// <param name="req"><see cref="StartConfigRuleEvaluationRequest"/></param>
        /// <returns><see cref="StartConfigRuleEvaluationResponse"/></returns>
        public StartConfigRuleEvaluationResponse StartConfigRuleEvaluationSync(StartConfigRuleEvaluationRequest req)
        {
            return InternalRequestAsync<StartConfigRuleEvaluationResponse>(req, "StartConfigRuleEvaluation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to manually execute rule repairs.
        /// </summary>
        /// <param name="req"><see cref="StartRemediationRequest"/></param>
        /// <returns><see cref="StartRemediationResponse"/></returns>
        public Task<StartRemediationResponse> StartRemediation(StartRemediationRequest req)
        {
            return InternalRequestAsync<StartRemediationResponse>(req, "StartRemediation");
        }

        /// <summary>
        /// This API is used to manually execute rule repairs.
        /// </summary>
        /// <param name="req"><see cref="StartRemediationRequest"/></param>
        /// <returns><see cref="StartRemediationResponse"/></returns>
        public StartRemediationResponse StartRemediationSync(StartRemediationRequest req)
        {
            return InternalRequestAsync<StartRemediationResponse>(req, "StartRemediation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit conformance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="UpdateAggregateCompliancePackRequest"/></param>
        /// <returns><see cref="UpdateAggregateCompliancePackResponse"/></returns>
        public Task<UpdateAggregateCompliancePackResponse> UpdateAggregateCompliancePack(UpdateAggregateCompliancePackRequest req)
        {
            return InternalRequestAsync<UpdateAggregateCompliancePackResponse>(req, "UpdateAggregateCompliancePack");
        }

        /// <summary>
        /// This API is used to edit conformance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="UpdateAggregateCompliancePackRequest"/></param>
        /// <returns><see cref="UpdateAggregateCompliancePackResponse"/></returns>
        public UpdateAggregateCompliancePackResponse UpdateAggregateCompliancePackSync(UpdateAggregateCompliancePackRequest req)
        {
            return InternalRequestAsync<UpdateAggregateCompliancePackResponse>(req, "UpdateAggregateCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable compliance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="UpdateAggregateCompliancePackStatusRequest"/></param>
        /// <returns><see cref="UpdateAggregateCompliancePackStatusResponse"/></returns>
        public Task<UpdateAggregateCompliancePackStatusResponse> UpdateAggregateCompliancePackStatus(UpdateAggregateCompliancePackStatusRequest req)
        {
            return InternalRequestAsync<UpdateAggregateCompliancePackStatusResponse>(req, "UpdateAggregateCompliancePackStatus");
        }

        /// <summary>
        /// This API is used to enable or disable compliance packages for account groups.
        /// </summary>
        /// <param name="req"><see cref="UpdateAggregateCompliancePackStatusRequest"/></param>
        /// <returns><see cref="UpdateAggregateCompliancePackStatusResponse"/></returns>
        public UpdateAggregateCompliancePackStatusResponse UpdateAggregateCompliancePackStatusSync(UpdateAggregateCompliancePackStatusRequest req)
        {
            return InternalRequestAsync<UpdateAggregateCompliancePackStatusResponse>(req, "UpdateAggregateCompliancePackStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit delivery settings for account groups.
        /// </summary>
        /// <param name="req"><see cref="UpdateAggregateConfigDeliverRequest"/></param>
        /// <returns><see cref="UpdateAggregateConfigDeliverResponse"/></returns>
        public Task<UpdateAggregateConfigDeliverResponse> UpdateAggregateConfigDeliver(UpdateAggregateConfigDeliverRequest req)
        {
            return InternalRequestAsync<UpdateAggregateConfigDeliverResponse>(req, "UpdateAggregateConfigDeliver");
        }

        /// <summary>
        /// This API is used to edit delivery settings for account groups.
        /// </summary>
        /// <param name="req"><see cref="UpdateAggregateConfigDeliverRequest"/></param>
        /// <returns><see cref="UpdateAggregateConfigDeliverResponse"/></returns>
        public UpdateAggregateConfigDeliverResponse UpdateAggregateConfigDeliverSync(UpdateAggregateConfigDeliverRequest req)
        {
            return InternalRequestAsync<UpdateAggregateConfigDeliverResponse>(req, "UpdateAggregateConfigDeliver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit rules for account groups.
        /// </summary>
        /// <param name="req"><see cref="UpdateAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="UpdateAggregateConfigRuleResponse"/></returns>
        public Task<UpdateAggregateConfigRuleResponse> UpdateAggregateConfigRule(UpdateAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<UpdateAggregateConfigRuleResponse>(req, "UpdateAggregateConfigRule");
        }

        /// <summary>
        /// This API is used to edit rules for account groups.
        /// </summary>
        /// <param name="req"><see cref="UpdateAggregateConfigRuleRequest"/></param>
        /// <returns><see cref="UpdateAggregateConfigRuleResponse"/></returns>
        public UpdateAggregateConfigRuleResponse UpdateAggregateConfigRuleSync(UpdateAggregateConfigRuleRequest req)
        {
            return InternalRequestAsync<UpdateAggregateConfigRuleResponse>(req, "UpdateAggregateConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit an account group.
        /// </summary>
        /// <param name="req"><see cref="UpdateAggregatorRequest"/></param>
        /// <returns><see cref="UpdateAggregatorResponse"/></returns>
        public Task<UpdateAggregatorResponse> UpdateAggregator(UpdateAggregatorRequest req)
        {
            return InternalRequestAsync<UpdateAggregatorResponse>(req, "UpdateAggregator");
        }

        /// <summary>
        /// Edit an account group.
        /// </summary>
        /// <param name="req"><see cref="UpdateAggregatorRequest"/></param>
        /// <returns><see cref="UpdateAggregatorResponse"/></returns>
        public UpdateAggregatorResponse UpdateAggregatorSync(UpdateAggregatorRequest req)
        {
            return InternalRequestAsync<UpdateAggregatorResponse>(req, "UpdateAggregator")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updating an Alarm Rule
        /// </summary>
        /// <param name="req"><see cref="UpdateAlarmPolicyRequest"/></param>
        /// <returns><see cref="UpdateAlarmPolicyResponse"/></returns>
        public Task<UpdateAlarmPolicyResponse> UpdateAlarmPolicy(UpdateAlarmPolicyRequest req)
        {
            return InternalRequestAsync<UpdateAlarmPolicyResponse>(req, "UpdateAlarmPolicy");
        }

        /// <summary>
        /// Updating an Alarm Rule
        /// </summary>
        /// <param name="req"><see cref="UpdateAlarmPolicyRequest"/></param>
        /// <returns><see cref="UpdateAlarmPolicyResponse"/></returns>
        public UpdateAlarmPolicyResponse UpdateAlarmPolicySync(UpdateAlarmPolicyRequest req)
        {
            return InternalRequestAsync<UpdateAlarmPolicyResponse>(req, "UpdateAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit a conformance pack.
        /// </summary>
        /// <param name="req"><see cref="UpdateCompliancePackRequest"/></param>
        /// <returns><see cref="UpdateCompliancePackResponse"/></returns>
        public Task<UpdateCompliancePackResponse> UpdateCompliancePack(UpdateCompliancePackRequest req)
        {
            return InternalRequestAsync<UpdateCompliancePackResponse>(req, "UpdateCompliancePack");
        }

        /// <summary>
        /// This API is used to edit a conformance pack.
        /// </summary>
        /// <param name="req"><see cref="UpdateCompliancePackRequest"/></param>
        /// <returns><see cref="UpdateCompliancePackResponse"/></returns>
        public UpdateCompliancePackResponse UpdateCompliancePackSync(UpdateCompliancePackRequest req)
        {
            return InternalRequestAsync<UpdateCompliancePackResponse>(req, "UpdateCompliancePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable compliance packages.
        /// </summary>
        /// <param name="req"><see cref="UpdateCompliancePackStatusRequest"/></param>
        /// <returns><see cref="UpdateCompliancePackStatusResponse"/></returns>
        public Task<UpdateCompliancePackStatusResponse> UpdateCompliancePackStatus(UpdateCompliancePackStatusRequest req)
        {
            return InternalRequestAsync<UpdateCompliancePackStatusResponse>(req, "UpdateCompliancePackStatus");
        }

        /// <summary>
        /// This API is used to enable or disable compliance packages.
        /// </summary>
        /// <param name="req"><see cref="UpdateCompliancePackStatusRequest"/></param>
        /// <returns><see cref="UpdateCompliancePackStatusResponse"/></returns>
        public UpdateCompliancePackStatusResponse UpdateCompliancePackStatusSync(UpdateCompliancePackStatusRequest req)
        {
            return InternalRequestAsync<UpdateCompliancePackStatusResponse>(req, "UpdateCompliancePackStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit shipping settings.
        /// </summary>
        /// <param name="req"><see cref="UpdateConfigDeliverRequest"/></param>
        /// <returns><see cref="UpdateConfigDeliverResponse"/></returns>
        public Task<UpdateConfigDeliverResponse> UpdateConfigDeliver(UpdateConfigDeliverRequest req)
        {
            return InternalRequestAsync<UpdateConfigDeliverResponse>(req, "UpdateConfigDeliver");
        }

        /// <summary>
        /// This API is used to edit shipping settings.
        /// </summary>
        /// <param name="req"><see cref="UpdateConfigDeliverRequest"/></param>
        /// <returns><see cref="UpdateConfigDeliverResponse"/></returns>
        public UpdateConfigDeliverResponse UpdateConfigDeliverSync(UpdateConfigDeliverRequest req)
        {
            return InternalRequestAsync<UpdateConfigDeliverResponse>(req, "UpdateConfigDeliver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit the monitoring scope.
        /// </summary>
        /// <param name="req"><see cref="UpdateConfigRecorderRequest"/></param>
        /// <returns><see cref="UpdateConfigRecorderResponse"/></returns>
        public Task<UpdateConfigRecorderResponse> UpdateConfigRecorder(UpdateConfigRecorderRequest req)
        {
            return InternalRequestAsync<UpdateConfigRecorderResponse>(req, "UpdateConfigRecorder");
        }

        /// <summary>
        /// Edit the monitoring scope.
        /// </summary>
        /// <param name="req"><see cref="UpdateConfigRecorderRequest"/></param>
        /// <returns><see cref="UpdateConfigRecorderResponse"/></returns>
        public UpdateConfigRecorderResponse UpdateConfigRecorderSync(UpdateConfigRecorderRequest req)
        {
            return InternalRequestAsync<UpdateConfigRecorderResponse>(req, "UpdateConfigRecorder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit a rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateConfigRuleRequest"/></param>
        /// <returns><see cref="UpdateConfigRuleResponse"/></returns>
        public Task<UpdateConfigRuleResponse> UpdateConfigRule(UpdateConfigRuleRequest req)
        {
            return InternalRequestAsync<UpdateConfigRuleResponse>(req, "UpdateConfigRule");
        }

        /// <summary>
        /// This API is used to edit a rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateConfigRuleRequest"/></param>
        /// <returns><see cref="UpdateConfigRuleResponse"/></returns>
        public UpdateConfigRuleResponse UpdateConfigRuleSync(UpdateConfigRuleRequest req)
        {
            return InternalRequestAsync<UpdateConfigRuleResponse>(req, "UpdateConfigRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add alarm monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="UpdateRemediationRequest"/></param>
        /// <returns><see cref="UpdateRemediationResponse"/></returns>
        public Task<UpdateRemediationResponse> UpdateRemediation(UpdateRemediationRequest req)
        {
            return InternalRequestAsync<UpdateRemediationResponse>(req, "UpdateRemediation");
        }

        /// <summary>
        /// This API is used to add alarm monitoring rules.
        /// </summary>
        /// <param name="req"><see cref="UpdateRemediationRequest"/></param>
        /// <returns><see cref="UpdateRemediationResponse"/></returns>
        public UpdateRemediationResponse UpdateRemediationSync(UpdateRemediationRequest req)
        {
            return InternalRequestAsync<UpdateRemediationResponse>(req, "UpdateRemediation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
