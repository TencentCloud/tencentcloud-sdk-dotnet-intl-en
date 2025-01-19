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

namespace TencentCloud.Monitor.V20180724
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Monitor.V20180724.Models;

   public class MonitorClient : AbstractClient{

       private const string endpoint = "monitor.tencentcloudapi.com";
       private const string version = "2018-07-24";
       private const string sdkVersion = "SDK_NET_3.0.1057";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MonitorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MonitorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to bind a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="BindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="BindPrometheusManagedGrafanaResponse"/></returns>
        public Task<BindPrometheusManagedGrafanaResponse> BindPrometheusManagedGrafana(BindPrometheusManagedGrafanaRequest req)
        {
            return InternalRequestAsync<BindPrometheusManagedGrafanaResponse>(req, "BindPrometheusManagedGrafana");
        }

        /// <summary>
        /// This API is used to bind a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="BindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="BindPrometheusManagedGrafanaResponse"/></returns>
        public BindPrometheusManagedGrafanaResponse BindPrometheusManagedGrafanaSync(BindPrometheusManagedGrafanaRequest req)
        {
            return InternalRequestAsync<BindPrometheusManagedGrafanaResponse>(req, "BindPrometheusManagedGrafana")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an alarm policy to a specific object.
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public Task<BindingPolicyObjectResponse> BindingPolicyObject(BindingPolicyObjectRequest req)
        {
            return InternalRequestAsync<BindingPolicyObjectResponse>(req, "BindingPolicyObject");
        }

        /// <summary>
        /// This API is used to bind an alarm policy to a specific object.
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public BindingPolicyObjectResponse BindingPolicyObjectSync(BindingPolicyObjectRequest req)
        {
            return InternalRequestAsync<BindingPolicyObjectResponse>(req, "BindingPolicyObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to determine whether the user is new to TMP, that is, whether the user has never created a TMP instance in any region.
        /// </summary>
        /// <param name="req"><see cref="CheckIsPrometheusNewUserRequest"/></param>
        /// <returns><see cref="CheckIsPrometheusNewUserResponse"/></returns>
        public Task<CheckIsPrometheusNewUserResponse> CheckIsPrometheusNewUser(CheckIsPrometheusNewUserRequest req)
        {
            return InternalRequestAsync<CheckIsPrometheusNewUserResponse>(req, "CheckIsPrometheusNewUser");
        }

        /// <summary>
        /// This API is used to determine whether the user is new to TMP, that is, whether the user has never created a TMP instance in any region.
        /// </summary>
        /// <param name="req"><see cref="CheckIsPrometheusNewUserRequest"/></param>
        /// <returns><see cref="CheckIsPrometheusNewUserResponse"/></returns>
        public CheckIsPrometheusNewUserResponse CheckIsPrometheusNewUserSync(CheckIsPrometheusNewUserRequest req)
        {
            return InternalRequestAsync<CheckIsPrometheusNewUserResponse>(req, "CheckIsPrometheusNewUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to forcibly terminate a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="CleanGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CleanGrafanaInstanceResponse"/></returns>
        public Task<CleanGrafanaInstanceResponse> CleanGrafanaInstance(CleanGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<CleanGrafanaInstanceResponse>(req, "CleanGrafanaInstance");
        }

        /// <summary>
        /// This API is used to forcibly terminate a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="CleanGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CleanGrafanaInstanceResponse"/></returns>
        public CleanGrafanaInstanceResponse CleanGrafanaInstanceSync(CleanGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<CleanGrafanaInstanceResponse>(req, "CleanGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a notification template.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public Task<CreateAlarmNoticeResponse> CreateAlarmNotice(CreateAlarmNoticeRequest req)
        {
            return InternalRequestAsync<CreateAlarmNoticeResponse>(req, "CreateAlarmNotice");
        }

        /// <summary>
        /// This API is used to create a notification template.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public CreateAlarmNoticeResponse CreateAlarmNoticeSync(CreateAlarmNoticeRequest req)
        {
            return InternalRequestAsync<CreateAlarmNoticeResponse>(req, "CreateAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmPolicyRequest"/></param>
        /// <returns><see cref="CreateAlarmPolicyResponse"/></returns>
        public Task<CreateAlarmPolicyResponse> CreateAlarmPolicy(CreateAlarmPolicyRequest req)
        {
            return InternalRequestAsync<CreateAlarmPolicyResponse>(req, "CreateAlarmPolicy");
        }

        /// <summary>
        /// This API is used to create an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmPolicyRequest"/></param>
        /// <returns><see cref="CreateAlarmPolicyResponse"/></returns>
        public CreateAlarmPolicyResponse CreateAlarmPolicySync(CreateAlarmPolicyRequest req)
        {
            return InternalRequestAsync<CreateAlarmPolicyResponse>(req, "CreateAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Prometheus alerting rule.
        /// 
        /// Note that alert object and alert message are special fields of Prometheus Rule Annotations, which need to be passed in through `annotations` and correspond to `summary` and `description` keys respectively. For more information, see [Alerting rules](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/).
        /// </summary>
        /// <param name="req"><see cref="CreateAlertRuleRequest"/></param>
        /// <returns><see cref="CreateAlertRuleResponse"/></returns>
        public Task<CreateAlertRuleResponse> CreateAlertRule(CreateAlertRuleRequest req)
        {
            return InternalRequestAsync<CreateAlertRuleResponse>(req, "CreateAlertRule");
        }

        /// <summary>
        /// This API is used to create a Prometheus alerting rule.
        /// 
        /// Note that alert object and alert message are special fields of Prometheus Rule Annotations, which need to be passed in through `annotations` and correspond to `summary` and `description` keys respectively. For more information, see [Alerting rules](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/).
        /// </summary>
        /// <param name="req"><see cref="CreateAlertRuleRequest"/></param>
        /// <returns><see cref="CreateAlertRuleResponse"/></returns>
        public CreateAlertRuleResponse CreateAlertRuleSync(CreateAlertRuleRequest req)
        {
            return InternalRequestAsync<CreateAlertRuleResponse>(req, "CreateAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an exporter integration.
        /// </summary>
        /// <param name="req"><see cref="CreateExporterIntegrationRequest"/></param>
        /// <returns><see cref="CreateExporterIntegrationResponse"/></returns>
        public Task<CreateExporterIntegrationResponse> CreateExporterIntegration(CreateExporterIntegrationRequest req)
        {
            return InternalRequestAsync<CreateExporterIntegrationResponse>(req, "CreateExporterIntegration");
        }

        /// <summary>
        /// This API is used to create an exporter integration.
        /// </summary>
        /// <param name="req"><see cref="CreateExporterIntegrationRequest"/></param>
        /// <returns><see cref="CreateExporterIntegrationResponse"/></returns>
        public CreateExporterIntegrationResponse CreateExporterIntegrationSync(CreateExporterIntegrationRequest req)
        {
            return InternalRequestAsync<CreateExporterIntegrationResponse>(req, "CreateExporterIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a monthly subscribed TCMG instance of the Basic Edition, with auto-renewal enabled and vouchers not allowed by default.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CreateGrafanaInstanceResponse"/></returns>
        public Task<CreateGrafanaInstanceResponse> CreateGrafanaInstance(CreateGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<CreateGrafanaInstanceResponse>(req, "CreateGrafanaInstance");
        }

        /// <summary>
        /// This API is used to create a monthly subscribed TCMG instance of the Basic Edition, with auto-renewal enabled and vouchers not allowed by default.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CreateGrafanaInstanceResponse"/></returns>
        public CreateGrafanaInstanceResponse CreateGrafanaInstanceSync(CreateGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<CreateGrafanaInstanceResponse>(req, "CreateGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="CreateGrafanaIntegrationResponse"/></returns>
        public Task<CreateGrafanaIntegrationResponse> CreateGrafanaIntegration(CreateGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<CreateGrafanaIntegrationResponse>(req, "CreateGrafanaIntegration");
        }

        /// <summary>
        /// This API is used to create a Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="CreateGrafanaIntegrationResponse"/></returns>
        public CreateGrafanaIntegrationResponse CreateGrafanaIntegrationSync(CreateGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<CreateGrafanaIntegrationResponse>(req, "CreateGrafanaIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="CreateGrafanaNotificationChannelResponse"/></returns>
        public Task<CreateGrafanaNotificationChannelResponse> CreateGrafanaNotificationChannel(CreateGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<CreateGrafanaNotificationChannelResponse>(req, "CreateGrafanaNotificationChannel");
        }

        /// <summary>
        /// This API is used to create a Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="CreateGrafanaNotificationChannelResponse"/></returns>
        public CreateGrafanaNotificationChannelResponse CreateGrafanaNotificationChannelSync(CreateGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<CreateGrafanaNotificationChannelResponse>(req, "CreateGrafanaNotificationChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a policy group.
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public Task<CreatePolicyGroupResponse> CreatePolicyGroup(CreatePolicyGroupRequest req)
        {
            return InternalRequestAsync<CreatePolicyGroupResponse>(req, "CreatePolicyGroup");
        }

        /// <summary>
        /// This API is used to add a policy group.
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public CreatePolicyGroupResponse CreatePolicyGroupSync(CreatePolicyGroupRequest req)
        {
            return InternalRequestAsync<CreatePolicyGroupResponse>(req, "CreatePolicyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Prometheus CVM agent.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusAgentResponse"/></returns>
        public Task<CreatePrometheusAgentResponse> CreatePrometheusAgent(CreatePrometheusAgentRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAgentResponse>(req, "CreatePrometheusAgent");
        }

        /// <summary>
        /// This API is used to create a Prometheus CVM agent.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusAgentResponse"/></returns>
        public CreatePrometheusAgentResponse CreatePrometheusAgentSync(CreatePrometheusAgentRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAgentResponse>(req, "CreatePrometheusAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an alerting rule.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertPolicyResponse"/></returns>
        public Task<CreatePrometheusAlertPolicyResponse> CreatePrometheusAlertPolicy(CreatePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertPolicyResponse>(req, "CreatePrometheusAlertPolicy");
        }

        /// <summary>
        /// This API is used to create an alerting rule.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertPolicyResponse"/></returns>
        public CreatePrometheusAlertPolicyResponse CreatePrometheusAlertPolicySync(CreatePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertPolicyResponse>(req, "CreatePrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to associate a cluster with a Cloud Monitor (CM)-integrated Tencent Managed Service for Prometheus (TMP) 2.0 instance.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusClusterAgentResponse"/></returns>
        public Task<CreatePrometheusClusterAgentResponse> CreatePrometheusClusterAgent(CreatePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<CreatePrometheusClusterAgentResponse>(req, "CreatePrometheusClusterAgent");
        }

        /// <summary>
        /// This API is used to associate a cluster with a Cloud Monitor (CM)-integrated Tencent Managed Service for Prometheus (TMP) 2.0 instance.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusClusterAgentResponse"/></returns>
        public CreatePrometheusClusterAgentResponse CreatePrometheusClusterAgentSync(CreatePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<CreatePrometheusClusterAgentResponse>(req, "CreatePrometheusClusterAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create Prometheus configurations.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusConfigRequest"/></param>
        /// <returns><see cref="CreatePrometheusConfigResponse"/></returns>
        public Task<CreatePrometheusConfigResponse> CreatePrometheusConfig(CreatePrometheusConfigRequest req)
        {
            return InternalRequestAsync<CreatePrometheusConfigResponse>(req, "CreatePrometheusConfig");
        }

        /// <summary>
        /// This API is used to create Prometheus configurations.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusConfigRequest"/></param>
        /// <returns><see cref="CreatePrometheusConfigResponse"/></returns>
        public CreatePrometheusConfigResponse CreatePrometheusConfigSync(CreatePrometheusConfigRequest req)
        {
            return InternalRequestAsync<CreatePrometheusConfigResponse>(req, "CreatePrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="CreatePrometheusGlobalNotificationResponse"/></returns>
        public Task<CreatePrometheusGlobalNotificationResponse> CreatePrometheusGlobalNotification(CreatePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<CreatePrometheusGlobalNotificationResponse>(req, "CreatePrometheusGlobalNotification");
        }

        /// <summary>
        /// This API is used to create a global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="CreatePrometheusGlobalNotificationResponse"/></returns>
        public CreatePrometheusGlobalNotificationResponse CreatePrometheusGlobalNotificationSync(CreatePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<CreatePrometheusGlobalNotificationResponse>(req, "CreatePrometheusGlobalNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusMultiTenantInstancePostPayModeRequest"/></param>
        /// <returns><see cref="CreatePrometheusMultiTenantInstancePostPayModeResponse"/></returns>
        public Task<CreatePrometheusMultiTenantInstancePostPayModeResponse> CreatePrometheusMultiTenantInstancePostPayMode(CreatePrometheusMultiTenantInstancePostPayModeRequest req)
        {
            return InternalRequestAsync<CreatePrometheusMultiTenantInstancePostPayModeResponse>(req, "CreatePrometheusMultiTenantInstancePostPayMode");
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusMultiTenantInstancePostPayModeRequest"/></param>
        /// <returns><see cref="CreatePrometheusMultiTenantInstancePostPayModeResponse"/></returns>
        public CreatePrometheusMultiTenantInstancePostPayModeResponse CreatePrometheusMultiTenantInstancePostPayModeSync(CreatePrometheusMultiTenantInstancePostPayModeRequest req)
        {
            return InternalRequestAsync<CreatePrometheusMultiTenantInstancePostPayModeResponse>(req, "CreatePrometheusMultiTenantInstancePostPayMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a recording rule in the YAML way.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="CreatePrometheusRecordRuleYamlResponse"/></returns>
        public Task<CreatePrometheusRecordRuleYamlResponse> CreatePrometheusRecordRuleYaml(CreatePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<CreatePrometheusRecordRuleYamlResponse>(req, "CreatePrometheusRecordRuleYaml");
        }

        /// <summary>
        /// This API is used to create a recording rule in the YAML way.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="CreatePrometheusRecordRuleYamlResponse"/></returns>
        public CreatePrometheusRecordRuleYamlResponse CreatePrometheusRecordRuleYamlSync(CreatePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<CreatePrometheusRecordRuleYamlResponse>(req, "CreatePrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="CreatePrometheusScrapeJobResponse"/></returns>
        public Task<CreatePrometheusScrapeJobResponse> CreatePrometheusScrapeJob(CreatePrometheusScrapeJobRequest req)
        {
            return InternalRequestAsync<CreatePrometheusScrapeJobResponse>(req, "CreatePrometheusScrapeJob");
        }

        /// <summary>
        /// This API is used to create a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="CreatePrometheusScrapeJobResponse"/></returns>
        public CreatePrometheusScrapeJobResponse CreatePrometheusScrapeJobSync(CreatePrometheusScrapeJobRequest req)
        {
            return InternalRequestAsync<CreatePrometheusScrapeJobResponse>(req, "CreatePrometheusScrapeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TMP template.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTempRequest"/></param>
        /// <returns><see cref="CreatePrometheusTempResponse"/></returns>
        public Task<CreatePrometheusTempResponse> CreatePrometheusTemp(CreatePrometheusTempRequest req)
        {
            return InternalRequestAsync<CreatePrometheusTempResponse>(req, "CreatePrometheusTemp");
        }

        /// <summary>
        /// This API is used to create a TMP template.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTempRequest"/></param>
        /// <returns><see cref="CreatePrometheusTempResponse"/></returns>
        public CreatePrometheusTempResponse CreatePrometheusTempSync(CreatePrometheusTempRequest req)
        {
            return InternalRequestAsync<CreatePrometheusTempResponse>(req, "CreatePrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Prometheus recording rule.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingRuleRequest"/></param>
        /// <returns><see cref="CreateRecordingRuleResponse"/></returns>
        public Task<CreateRecordingRuleResponse> CreateRecordingRule(CreateRecordingRuleRequest req)
        {
            return InternalRequestAsync<CreateRecordingRuleResponse>(req, "CreateRecordingRule");
        }

        /// <summary>
        /// This API is used to create a Prometheus recording rule.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingRuleRequest"/></param>
        /// <returns><see cref="CreateRecordingRuleResponse"/></returns>
        public CreateRecordingRuleResponse CreateRecordingRuleSync(CreateRecordingRuleRequest req)
        {
            return InternalRequestAsync<CreateRecordingRuleResponse>(req, "CreateRecordingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to authorize a Grafana instance to another Tencent Cloud user.
        /// </summary>
        /// <param name="req"><see cref="CreateSSOAccountRequest"/></param>
        /// <returns><see cref="CreateSSOAccountResponse"/></returns>
        public Task<CreateSSOAccountResponse> CreateSSOAccount(CreateSSOAccountRequest req)
        {
            return InternalRequestAsync<CreateSSOAccountResponse>(req, "CreateSSOAccount");
        }

        /// <summary>
        /// This API is used to authorize a Grafana instance to another Tencent Cloud user.
        /// </summary>
        /// <param name="req"><see cref="CreateSSOAccountRequest"/></param>
        /// <returns><see cref="CreateSSOAccountResponse"/></returns>
        public CreateSSOAccountResponse CreateSSOAccountSync(CreateSSOAccountRequest req)
        {
            return InternalRequestAsync<CreateSSOAccountResponse>(req, "CreateSSOAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Prometheus scrape configuration in TKE.
        /// <p>Note: The prerequisite is that the corresponding TKE service has been integrated through the Prometheus console. For more information, see
        /// <a href="https://intl.cloud.tencent.com/document/product/248/48859?from_cn_redirect=1" target="_blank">Agent Management</a>.</p>
        /// </summary>
        /// <param name="req"><see cref="CreateServiceDiscoveryRequest"/></param>
        /// <returns><see cref="CreateServiceDiscoveryResponse"/></returns>
        public Task<CreateServiceDiscoveryResponse> CreateServiceDiscovery(CreateServiceDiscoveryRequest req)
        {
            return InternalRequestAsync<CreateServiceDiscoveryResponse>(req, "CreateServiceDiscovery");
        }

        /// <summary>
        /// This API is used to create a Prometheus scrape configuration in TKE.
        /// <p>Note: The prerequisite is that the corresponding TKE service has been integrated through the Prometheus console. For more information, see
        /// <a href="https://intl.cloud.tencent.com/document/product/248/48859?from_cn_redirect=1" target="_blank">Agent Management</a>.</p>
        /// </summary>
        /// <param name="req"><see cref="CreateServiceDiscoveryRequest"/></param>
        /// <returns><see cref="CreateServiceDiscoveryResponse"/></returns>
        public CreateServiceDiscoveryResponse CreateServiceDiscoverySync(CreateServiceDiscoveryRequest req)
        {
            return InternalRequestAsync<CreateServiceDiscoveryResponse>(req, "CreateServiceDiscovery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticesRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticesResponse"/></returns>
        public Task<DeleteAlarmNoticesResponse> DeleteAlarmNotices(DeleteAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DeleteAlarmNoticesResponse>(req, "DeleteAlarmNotices");
        }

        /// <summary>
        /// This API is used to delete an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticesRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticesResponse"/></returns>
        public DeleteAlarmNoticesResponse DeleteAlarmNoticesSync(DeleteAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DeleteAlarmNoticesResponse>(req, "DeleteAlarmNotices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmPolicyRequest"/></param>
        /// <returns><see cref="DeleteAlarmPolicyResponse"/></returns>
        public Task<DeleteAlarmPolicyResponse> DeleteAlarmPolicy(DeleteAlarmPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAlarmPolicyResponse>(req, "DeleteAlarmPolicy");
        }

        /// <summary>
        /// This API is used to delete an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmPolicyRequest"/></param>
        /// <returns><see cref="DeleteAlarmPolicyResponse"/></returns>
        public DeleteAlarmPolicyResponse DeleteAlarmPolicySync(DeleteAlarmPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAlarmPolicyResponse>(req, "DeleteAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete Prometheus alerting rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertRulesRequest"/></param>
        /// <returns><see cref="DeleteAlertRulesResponse"/></returns>
        public Task<DeleteAlertRulesResponse> DeleteAlertRules(DeleteAlertRulesRequest req)
        {
            return InternalRequestAsync<DeleteAlertRulesResponse>(req, "DeleteAlertRules");
        }

        /// <summary>
        /// This API is used to batch delete Prometheus alerting rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertRulesRequest"/></param>
        /// <returns><see cref="DeleteAlertRulesResponse"/></returns>
        public DeleteAlertRulesResponse DeleteAlertRulesSync(DeleteAlertRulesRequest req)
        {
            return InternalRequestAsync<DeleteAlertRulesResponse>(req, "DeleteAlertRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an exporter integration.
        /// </summary>
        /// <param name="req"><see cref="DeleteExporterIntegrationRequest"/></param>
        /// <returns><see cref="DeleteExporterIntegrationResponse"/></returns>
        public Task<DeleteExporterIntegrationResponse> DeleteExporterIntegration(DeleteExporterIntegrationRequest req)
        {
            return InternalRequestAsync<DeleteExporterIntegrationResponse>(req, "DeleteExporterIntegration");
        }

        /// <summary>
        /// This API is used to delete an exporter integration.
        /// </summary>
        /// <param name="req"><see cref="DeleteExporterIntegrationRequest"/></param>
        /// <returns><see cref="DeleteExporterIntegrationResponse"/></returns>
        public DeleteExporterIntegrationResponse DeleteExporterIntegrationSync(DeleteExporterIntegrationRequest req)
        {
            return InternalRequestAsync<DeleteExporterIntegrationResponse>(req, "DeleteExporterIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to refund a monthly subscribed TCMG instance. Once it is called, the instance cannot be used and will be automatically terminated seven days later.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaInstanceRequest"/></param>
        /// <returns><see cref="DeleteGrafanaInstanceResponse"/></returns>
        public Task<DeleteGrafanaInstanceResponse> DeleteGrafanaInstance(DeleteGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaInstanceResponse>(req, "DeleteGrafanaInstance");
        }

        /// <summary>
        /// This API is used to refund a monthly subscribed TCMG instance. Once it is called, the instance cannot be used and will be automatically terminated seven days later.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaInstanceRequest"/></param>
        /// <returns><see cref="DeleteGrafanaInstanceResponse"/></returns>
        public DeleteGrafanaInstanceResponse DeleteGrafanaInstanceSync(DeleteGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaInstanceResponse>(req, "DeleteGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="DeleteGrafanaIntegrationResponse"/></returns>
        public Task<DeleteGrafanaIntegrationResponse> DeleteGrafanaIntegration(DeleteGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaIntegrationResponse>(req, "DeleteGrafanaIntegration");
        }

        /// <summary>
        /// This API is used to delete a Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="DeleteGrafanaIntegrationResponse"/></returns>
        public DeleteGrafanaIntegrationResponse DeleteGrafanaIntegrationSync(DeleteGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaIntegrationResponse>(req, "DeleteGrafanaIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="DeleteGrafanaNotificationChannelResponse"/></returns>
        public Task<DeleteGrafanaNotificationChannelResponse> DeleteGrafanaNotificationChannel(DeleteGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaNotificationChannelResponse>(req, "DeleteGrafanaNotificationChannel");
        }

        /// <summary>
        /// This API is used to delete a Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="DeleteGrafanaNotificationChannelResponse"/></returns>
        public DeleteGrafanaNotificationChannelResponse DeleteGrafanaNotificationChannelSync(DeleteGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaNotificationChannelResponse>(req, "DeleteGrafanaNotificationChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an alarm policy group.
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public Task<DeletePolicyGroupResponse> DeletePolicyGroup(DeletePolicyGroupRequest req)
        {
            return InternalRequestAsync<DeletePolicyGroupResponse>(req, "DeletePolicyGroup");
        }

        /// <summary>
        /// This API is used to delete an alarm policy group.
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public DeletePolicyGroupResponse DeletePolicyGroupSync(DeletePolicyGroupRequest req)
        {
            return InternalRequestAsync<DeletePolicyGroupResponse>(req, "DeletePolicyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a TMP 2.0 instance alerting rule.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertPolicyResponse"/></returns>
        public Task<DeletePrometheusAlertPolicyResponse> DeletePrometheusAlertPolicy(DeletePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertPolicyResponse>(req, "DeletePrometheusAlertPolicy");
        }

        /// <summary>
        /// This API is used to delete a TMP 2.0 instance alerting rule.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertPolicyResponse"/></returns>
        public DeletePrometheusAlertPolicyResponse DeletePrometheusAlertPolicySync(DeletePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertPolicyResponse>(req, "DeletePrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disassociate a TMP instance from a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="DeletePrometheusClusterAgentResponse"/></returns>
        public Task<DeletePrometheusClusterAgentResponse> DeletePrometheusClusterAgent(DeletePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<DeletePrometheusClusterAgentResponse>(req, "DeletePrometheusClusterAgent");
        }

        /// <summary>
        /// This API is used to disassociate a TMP instance from a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="DeletePrometheusClusterAgentResponse"/></returns>
        public DeletePrometheusClusterAgentResponse DeletePrometheusClusterAgentSync(DeletePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<DeletePrometheusClusterAgentResponse>(req, "DeletePrometheusClusterAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Prometheus configurations. If the target cluster does not exist, a result indicating success will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusConfigRequest"/></param>
        /// <returns><see cref="DeletePrometheusConfigResponse"/></returns>
        public Task<DeletePrometheusConfigResponse> DeletePrometheusConfig(DeletePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DeletePrometheusConfigResponse>(req, "DeletePrometheusConfig");
        }

        /// <summary>
        /// This API is used to delete Prometheus configurations. If the target cluster does not exist, a result indicating success will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusConfigRequest"/></param>
        /// <returns><see cref="DeletePrometheusConfigResponse"/></returns>
        public DeletePrometheusConfigResponse DeletePrometheusConfigSync(DeletePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DeletePrometheusConfigResponse>(req, "DeletePrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a recording instance.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DeletePrometheusRecordRuleYamlResponse"/></returns>
        public Task<DeletePrometheusRecordRuleYamlResponse> DeletePrometheusRecordRuleYaml(DeletePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<DeletePrometheusRecordRuleYamlResponse>(req, "DeletePrometheusRecordRuleYaml");
        }

        /// <summary>
        /// This API is used to delete a recording instance.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DeletePrometheusRecordRuleYamlResponse"/></returns>
        public DeletePrometheusRecordRuleYamlResponse DeletePrometheusRecordRuleYamlSync(DeletePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<DeletePrometheusRecordRuleYamlResponse>(req, "DeletePrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DeletePrometheusScrapeJobsResponse"/></returns>
        public Task<DeletePrometheusScrapeJobsResponse> DeletePrometheusScrapeJobs(DeletePrometheusScrapeJobsRequest req)
        {
            return InternalRequestAsync<DeletePrometheusScrapeJobsResponse>(req, "DeletePrometheusScrapeJobs");
        }

        /// <summary>
        /// This API is used to delete a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DeletePrometheusScrapeJobsResponse"/></returns>
        public DeletePrometheusScrapeJobsResponse DeletePrometheusScrapeJobsSync(DeletePrometheusScrapeJobsRequest req)
        {
            return InternalRequestAsync<DeletePrometheusScrapeJobsResponse>(req, "DeletePrometheusScrapeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a TMP template.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempResponse"/></returns>
        public Task<DeletePrometheusTempResponse> DeletePrometheusTemp(DeletePrometheusTempRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempResponse>(req, "DeletePrometheusTemp");
        }

        /// <summary>
        /// This API is used to delete a TMP template.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempResponse"/></returns>
        public DeletePrometheusTempResponse DeletePrometheusTempSync(DeletePrometheusTempRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempResponse>(req, "DeletePrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unsync a template, which will delete the configuration generated by the template in the target. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempSyncResponse"/></returns>
        public Task<DeletePrometheusTempSyncResponse> DeletePrometheusTempSync(DeletePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempSyncResponse>(req, "DeletePrometheusTempSync");
        }

        /// <summary>
        /// This API is used to unsync a template, which will delete the configuration generated by the template in the target. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempSyncResponse"/></returns>
        public DeletePrometheusTempSyncResponse DeletePrometheusTempSyncSync(DeletePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempSyncResponse>(req, "DeletePrometheusTempSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete Prometheus recording rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingRulesRequest"/></param>
        /// <returns><see cref="DeleteRecordingRulesResponse"/></returns>
        public Task<DeleteRecordingRulesResponse> DeleteRecordingRules(DeleteRecordingRulesRequest req)
        {
            return InternalRequestAsync<DeleteRecordingRulesResponse>(req, "DeleteRecordingRules");
        }

        /// <summary>
        /// This API is used to batch delete Prometheus recording rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingRulesRequest"/></param>
        /// <returns><see cref="DeleteRecordingRulesResponse"/></returns>
        public DeleteRecordingRulesResponse DeleteRecordingRulesSync(DeleteRecordingRulesRequest req)
        {
            return InternalRequestAsync<DeleteRecordingRulesResponse>(req, "DeleteRecordingRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an authorized TCMG user.
        /// </summary>
        /// <param name="req"><see cref="DeleteSSOAccountRequest"/></param>
        /// <returns><see cref="DeleteSSOAccountResponse"/></returns>
        public Task<DeleteSSOAccountResponse> DeleteSSOAccount(DeleteSSOAccountRequest req)
        {
            return InternalRequestAsync<DeleteSSOAccountResponse>(req, "DeleteSSOAccount");
        }

        /// <summary>
        /// This API is used to delete an authorized TCMG user.
        /// </summary>
        /// <param name="req"><see cref="DeleteSSOAccountRequest"/></param>
        /// <returns><see cref="DeleteSSOAccountResponse"/></returns>
        public DeleteSSOAccountResponse DeleteSSOAccountSync(DeleteSSOAccountRequest req)
        {
            return InternalRequestAsync<DeleteSSOAccountResponse>(req, "DeleteSSOAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the platform event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public Task<DescribeAccidentEventListResponse> DescribeAccidentEventList(DescribeAccidentEventListRequest req)
        {
            return InternalRequestAsync<DescribeAccidentEventListResponse>(req, "DescribeAccidentEventList");
        }

        /// <summary>
        /// This API is used to get the platform event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public DescribeAccidentEventListResponse DescribeAccidentEventListSync(DescribeAccidentEventListRequest req)
        {
            return InternalRequestAsync<DescribeAccidentEventListResponse>(req, "DescribeAccidentEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of alarm events.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public Task<DescribeAlarmEventsResponse> DescribeAlarmEvents(DescribeAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmEventsResponse>(req, "DescribeAlarmEvents");
        }

        /// <summary>
        /// This API is used to query the list of alarm events.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public DescribeAlarmEventsResponse DescribeAlarmEventsSync(DescribeAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmEventsResponse>(req, "DescribeAlarmEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the alarm records.
        /// 
        /// Note: **If you use a sub-account, you can only query the alarm records of authorized projects** or uncategorized products.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmHistoriesResponse"/></returns>
        public Task<DescribeAlarmHistoriesResponse> DescribeAlarmHistories(DescribeAlarmHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmHistoriesResponse>(req, "DescribeAlarmHistories");
        }

        /// <summary>
        /// This API is used to query the alarm records.
        /// 
        /// Note: **If you use a sub-account, you can only query the alarm records of authorized projects** or uncategorized products.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmHistoriesResponse"/></returns>
        public DescribeAlarmHistoriesResponse DescribeAlarmHistoriesSync(DescribeAlarmHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmHistoriesResponse>(req, "DescribeAlarmHistories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of alarm metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmMetricsRequest"/></param>
        /// <returns><see cref="DescribeAlarmMetricsResponse"/></returns>
        public Task<DescribeAlarmMetricsResponse> DescribeAlarmMetrics(DescribeAlarmMetricsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmMetricsResponse>(req, "DescribeAlarmMetrics");
        }

        /// <summary>
        /// This API is used to query the list of alarm metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmMetricsRequest"/></param>
        /// <returns><see cref="DescribeAlarmMetricsResponse"/></returns>
        public DescribeAlarmMetricsResponse DescribeAlarmMetricsSync(DescribeAlarmMetricsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmMetricsResponse>(req, "DescribeAlarmMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a single notification template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeResponse"/></returns>
        public Task<DescribeAlarmNoticeResponse> DescribeAlarmNotice(DescribeAlarmNoticeRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticeResponse>(req, "DescribeAlarmNotice");
        }

        /// <summary>
        /// This API is used to query the details of a single notification template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeResponse"/></returns>
        public DescribeAlarmNoticeResponse DescribeAlarmNoticeSync(DescribeAlarmNoticeRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticeResponse>(req, "DescribeAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain all the callback URLs of an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeCallbacksRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeCallbacksResponse"/></returns>
        public Task<DescribeAlarmNoticeCallbacksResponse> DescribeAlarmNoticeCallbacks(DescribeAlarmNoticeCallbacksRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticeCallbacksResponse>(req, "DescribeAlarmNoticeCallbacks");
        }

        /// <summary>
        /// This API is used to obtain all the callback URLs of an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeCallbacksRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeCallbacksResponse"/></returns>
        public DescribeAlarmNoticeCallbacksResponse DescribeAlarmNoticeCallbacksSync(DescribeAlarmNoticeCallbacksRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticeCallbacksResponse>(req, "DescribeAlarmNoticeCallbacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of notification templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public Task<DescribeAlarmNoticesResponse> DescribeAlarmNotices(DescribeAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticesResponse>(req, "DescribeAlarmNotices");
        }

        /// <summary>
        /// This API is used to query the list of notification templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public DescribeAlarmNoticesResponse DescribeAlarmNoticesSync(DescribeAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticesResponse>(req, "DescribeAlarmNotices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of alarm policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAlarmPoliciesResponse"/></returns>
        public Task<DescribeAlarmPoliciesResponse> DescribeAlarmPolicies(DescribeAlarmPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmPoliciesResponse>(req, "DescribeAlarmPolicies");
        }

        /// <summary>
        /// This API is used to query the list of alarm policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAlarmPoliciesResponse"/></returns>
        public DescribeAlarmPoliciesResponse DescribeAlarmPoliciesSync(DescribeAlarmPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmPoliciesResponse>(req, "DescribeAlarmPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of a single alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPolicyRequest"/></param>
        /// <returns><see cref="DescribeAlarmPolicyResponse"/></returns>
        public Task<DescribeAlarmPolicyResponse> DescribeAlarmPolicy(DescribeAlarmPolicyRequest req)
        {
            return InternalRequestAsync<DescribeAlarmPolicyResponse>(req, "DescribeAlarmPolicy");
        }

        /// <summary>
        /// This API is used to get the details of a single alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPolicyRequest"/></param>
        /// <returns><see cref="DescribeAlarmPolicyResponse"/></returns>
        public DescribeAlarmPolicyResponse DescribeAlarmPolicySync(DescribeAlarmPolicyRequest req)
        {
            return InternalRequestAsync<DescribeAlarmPolicyResponse>(req, "DescribeAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a Prometheus alerting rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRulesRequest"/></param>
        /// <returns><see cref="DescribeAlertRulesResponse"/></returns>
        public Task<DescribeAlertRulesResponse> DescribeAlertRules(DescribeAlertRulesRequest req)
        {
            return InternalRequestAsync<DescribeAlertRulesResponse>(req, "DescribeAlertRules");
        }

        /// <summary>
        /// This API is used to query a Prometheus alerting rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRulesRequest"/></param>
        /// <returns><see cref="DescribeAlertRulesResponse"/></returns>
        public DescribeAlertRulesResponse DescribeAlertRulesSync(DescribeAlertRulesRequest req)
        {
            return InternalRequestAsync<DescribeAlertRulesResponse>(req, "DescribeAlertRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all namespaces.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeAllNamespacesResponse"/></returns>
        public Task<DescribeAllNamespacesResponse> DescribeAllNamespaces(DescribeAllNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeAllNamespacesResponse>(req, "DescribeAllNamespaces");
        }

        /// <summary>
        /// This API is used to query all namespaces.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeAllNamespacesResponse"/></returns>
        public DescribeAllNamespacesResponse DescribeAllNamespacesSync(DescribeAllNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeAllNamespacesResponse>(req, "DescribeAllNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the attributes of basic metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public Task<DescribeBaseMetricsResponse> DescribeBaseMetrics(DescribeBaseMetricsRequest req)
        {
            return InternalRequestAsync<DescribeBaseMetricsResponse>(req, "DescribeBaseMetrics");
        }

        /// <summary>
        /// This API is used to get the attributes of basic metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public DescribeBaseMetricsResponse DescribeBaseMetricsSync(DescribeBaseMetricsRequest req)
        {
            return InternalRequestAsync<DescribeBaseMetricsResponse>(req, "DescribeBaseMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the basic alarm list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public Task<DescribeBasicAlarmListResponse> DescribeBasicAlarmList(DescribeBasicAlarmListRequest req)
        {
            return InternalRequestAsync<DescribeBasicAlarmListResponse>(req, "DescribeBasicAlarmList");
        }

        /// <summary>
        /// This API is used to get the basic alarm list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public DescribeBasicAlarmListResponse DescribeBasicAlarmListSync(DescribeBasicAlarmListRequest req)
        {
            return InternalRequestAsync<DescribeBasicAlarmListResponse>(req, "DescribeBasicAlarmList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the bound object list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public Task<DescribeBindingPolicyObjectListResponse> DescribeBindingPolicyObjectList(DescribeBindingPolicyObjectListRequest req)
        {
            return InternalRequestAsync<DescribeBindingPolicyObjectListResponse>(req, "DescribeBindingPolicyObjectList");
        }

        /// <summary>
        /// This API is used to get the bound object list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public DescribeBindingPolicyObjectListResponse DescribeBindingPolicyObjectListSync(DescribeBindingPolicyObjectListRequest req)
        {
            return InternalRequestAsync<DescribeBindingPolicyObjectListResponse>(req, "DescribeBindingPolicyObjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the binding status between the TencentCloud Managed Service for Prometheus instance and the TKE cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAgentCreatingProgressRequest"/></param>
        /// <returns><see cref="DescribeClusterAgentCreatingProgressResponse"/></returns>
        public Task<DescribeClusterAgentCreatingProgressResponse> DescribeClusterAgentCreatingProgress(DescribeClusterAgentCreatingProgressRequest req)
        {
            return InternalRequestAsync<DescribeClusterAgentCreatingProgressResponse>(req, "DescribeClusterAgentCreatingProgress");
        }

        /// <summary>
        /// This API is used to obtain the binding status between the TencentCloud Managed Service for Prometheus instance and the TKE cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAgentCreatingProgressRequest"/></param>
        /// <returns><see cref="DescribeClusterAgentCreatingProgressResponse"/></returns>
        public DescribeClusterAgentCreatingProgressResponse DescribeClusterAgentCreatingProgressSync(DescribeClusterAgentCreatingProgressRequest req)
        {
            return InternalRequestAsync<DescribeClusterAgentCreatingProgressResponse>(req, "DescribeClusterAgentCreatingProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the trigger condition template.
        /// </summary>
        /// <param name="req"><see cref="DescribeConditionsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeConditionsTemplateListResponse"/></returns>
        public Task<DescribeConditionsTemplateListResponse> DescribeConditionsTemplateList(DescribeConditionsTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeConditionsTemplateListResponse>(req, "DescribeConditionsTemplateList");
        }

        /// <summary>
        /// This API is used to get the trigger condition template.
        /// </summary>
        /// <param name="req"><see cref="DescribeConditionsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeConditionsTemplateListResponse"/></returns>
        public DescribeConditionsTemplateListResponse DescribeConditionsTemplateListSync(DescribeConditionsTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeConditionsTemplateListResponse>(req, "DescribeConditionsTemplateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list Grafana DNS configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeDNSConfigRequest"/></param>
        /// <returns><see cref="DescribeDNSConfigResponse"/></returns>
        public Task<DescribeDNSConfigResponse> DescribeDNSConfig(DescribeDNSConfigRequest req)
        {
            return InternalRequestAsync<DescribeDNSConfigResponse>(req, "DescribeDNSConfig");
        }

        /// <summary>
        /// This API is used to list Grafana DNS configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeDNSConfigRequest"/></param>
        /// <returns><see cref="DescribeDNSConfigResponse"/></returns>
        public DescribeDNSConfigResponse DescribeDNSConfigSync(DescribeDNSConfigRequest req)
        {
            return InternalRequestAsync<DescribeDNSConfigResponse>(req, "DescribeDNSConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of exporter integrations.
        /// </summary>
        /// <param name="req"><see cref="DescribeExporterIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeExporterIntegrationsResponse"/></returns>
        public Task<DescribeExporterIntegrationsResponse> DescribeExporterIntegrations(DescribeExporterIntegrationsRequest req)
        {
            return InternalRequestAsync<DescribeExporterIntegrationsResponse>(req, "DescribeExporterIntegrations");
        }

        /// <summary>
        /// This API is used to query the list of exporter integrations.
        /// </summary>
        /// <param name="req"><see cref="DescribeExporterIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeExporterIntegrationsResponse"/></returns>
        public DescribeExporterIntegrationsResponse DescribeExporterIntegrationsSync(DescribeExporterIntegrationsRequest req)
        {
            return InternalRequestAsync<DescribeExporterIntegrationsResponse>(req, "DescribeExporterIntegrations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list all Grafana alert channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaChannelsResponse"/></returns>
        public Task<DescribeGrafanaChannelsResponse> DescribeGrafanaChannels(DescribeGrafanaChannelsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaChannelsResponse>(req, "DescribeGrafanaChannels");
        }

        /// <summary>
        /// This API is used to list all Grafana alert channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaChannelsResponse"/></returns>
        public DescribeGrafanaChannelsResponse DescribeGrafanaChannelsSync(DescribeGrafanaChannelsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaChannelsResponse>(req, "DescribeGrafanaChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list Grafana settings, i.e., the `grafana.ini` file content.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaConfigRequest"/></param>
        /// <returns><see cref="DescribeGrafanaConfigResponse"/></returns>
        public Task<DescribeGrafanaConfigResponse> DescribeGrafanaConfig(DescribeGrafanaConfigRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaConfigResponse>(req, "DescribeGrafanaConfig");
        }

        /// <summary>
        /// This API is used to list Grafana settings, i.e., the `grafana.ini` file content.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaConfigRequest"/></param>
        /// <returns><see cref="DescribeGrafanaConfigResponse"/></returns>
        public DescribeGrafanaConfigResponse DescribeGrafanaConfigSync(DescribeGrafanaConfigRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaConfigResponse>(req, "DescribeGrafanaConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list Grafana environment variables.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaEnvironmentsResponse"/></returns>
        public Task<DescribeGrafanaEnvironmentsResponse> DescribeGrafanaEnvironments(DescribeGrafanaEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaEnvironmentsResponse>(req, "DescribeGrafanaEnvironments");
        }

        /// <summary>
        /// This API is used to list Grafana environment variables.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaEnvironmentsResponse"/></returns>
        public DescribeGrafanaEnvironmentsResponse DescribeGrafanaEnvironmentsSync(DescribeGrafanaEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaEnvironmentsResponse>(req, "DescribeGrafanaEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list all Grafana instances under a user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaInstancesRequest"/></param>
        /// <returns><see cref="DescribeGrafanaInstancesResponse"/></returns>
        public Task<DescribeGrafanaInstancesResponse> DescribeGrafanaInstances(DescribeGrafanaInstancesRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaInstancesResponse>(req, "DescribeGrafanaInstances");
        }

        /// <summary>
        /// This API is used to list all Grafana instances under a user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaInstancesRequest"/></param>
        /// <returns><see cref="DescribeGrafanaInstancesResponse"/></returns>
        public DescribeGrafanaInstancesResponse DescribeGrafanaInstancesSync(DescribeGrafanaInstancesRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaInstancesResponse>(req, "DescribeGrafanaInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list installed Grafana integrations.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaIntegrationsResponse"/></returns>
        public Task<DescribeGrafanaIntegrationsResponse> DescribeGrafanaIntegrations(DescribeGrafanaIntegrationsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaIntegrationsResponse>(req, "DescribeGrafanaIntegrations");
        }

        /// <summary>
        /// This API is used to list installed Grafana integrations.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaIntegrationsResponse"/></returns>
        public DescribeGrafanaIntegrationsResponse DescribeGrafanaIntegrationsSync(DescribeGrafanaIntegrationsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaIntegrationsResponse>(req, "DescribeGrafanaIntegrations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list Grafana notification channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaNotificationChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaNotificationChannelsResponse"/></returns>
        public Task<DescribeGrafanaNotificationChannelsResponse> DescribeGrafanaNotificationChannels(DescribeGrafanaNotificationChannelsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaNotificationChannelsResponse>(req, "DescribeGrafanaNotificationChannels");
        }

        /// <summary>
        /// This API is used to list Grafana notification channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaNotificationChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaNotificationChannelsResponse"/></returns>
        public DescribeGrafanaNotificationChannelsResponse DescribeGrafanaNotificationChannelsSync(DescribeGrafanaNotificationChannelsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaNotificationChannelsResponse>(req, "DescribeGrafanaNotificationChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list the Grafana allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="DescribeGrafanaWhiteListResponse"/></returns>
        public Task<DescribeGrafanaWhiteListResponse> DescribeGrafanaWhiteList(DescribeGrafanaWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaWhiteListResponse>(req, "DescribeGrafanaWhiteList");
        }

        /// <summary>
        /// This API is used to list the Grafana allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="DescribeGrafanaWhiteListResponse"/></returns>
        public DescribeGrafanaWhiteListResponse DescribeGrafanaWhiteListSync(DescribeGrafanaWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaWhiteListResponse>(req, "DescribeGrafanaWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list the plugins installed in an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstalledPluginsRequest"/></param>
        /// <returns><see cref="DescribeInstalledPluginsResponse"/></returns>
        public Task<DescribeInstalledPluginsResponse> DescribeInstalledPlugins(DescribeInstalledPluginsRequest req)
        {
            return InternalRequestAsync<DescribeInstalledPluginsResponse>(req, "DescribeInstalledPlugins");
        }

        /// <summary>
        /// This API is used to list the plugins installed in an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstalledPluginsRequest"/></param>
        /// <returns><see cref="DescribeInstalledPluginsResponse"/></returns>
        public DescribeInstalledPluginsResponse DescribeInstalledPluginsSync(DescribeInstalledPluginsRequest req)
        {
            return InternalRequestAsync<DescribeInstalledPluginsResponse>(req, "DescribeInstalledPlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list all the monitoring types supported by CM.
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorTypesRequest"/></param>
        /// <returns><see cref="DescribeMonitorTypesResponse"/></returns>
        public Task<DescribeMonitorTypesResponse> DescribeMonitorTypes(DescribeMonitorTypesRequest req)
        {
            return InternalRequestAsync<DescribeMonitorTypesResponse>(req, "DescribeMonitorTypes");
        }

        /// <summary>
        /// This API is used to list all the monitoring types supported by CM.
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorTypesRequest"/></param>
        /// <returns><see cref="DescribeMonitorTypesResponse"/></returns>
        public DescribeMonitorTypesResponse DescribeMonitorTypesSync(DescribeMonitorTypesRequest req)
        {
            return InternalRequestAsync<DescribeMonitorTypesResponse>(req, "DescribeMonitorTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get basic alarm policy conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public Task<DescribePolicyConditionListResponse> DescribePolicyConditionList(DescribePolicyConditionListRequest req)
        {
            return InternalRequestAsync<DescribePolicyConditionListResponse>(req, "DescribePolicyConditionList");
        }

        /// <summary>
        /// This API is used to get basic alarm policy conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public DescribePolicyConditionListResponse DescribePolicyConditionListSync(DescribePolicyConditionListRequest req)
        {
            return InternalRequestAsync<DescribePolicyConditionListResponse>(req, "DescribePolicyConditionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get details of a basic policy group.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public Task<DescribePolicyGroupInfoResponse> DescribePolicyGroupInfo(DescribePolicyGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribePolicyGroupInfoResponse>(req, "DescribePolicyGroupInfo");
        }

        /// <summary>
        /// This API is used to get details of a basic policy group.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public DescribePolicyGroupInfoResponse DescribePolicyGroupInfoSync(DescribePolicyGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribePolicyGroupInfoResponse>(req, "DescribePolicyGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of basic policy alarm groups.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public Task<DescribePolicyGroupListResponse> DescribePolicyGroupList(DescribePolicyGroupListRequest req)
        {
            return InternalRequestAsync<DescribePolicyGroupListResponse>(req, "DescribePolicyGroupList");
        }

        /// <summary>
        /// This API is used to get the list of basic policy alarm groups.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public DescribePolicyGroupListResponse DescribePolicyGroupListSync(DescribePolicyGroupListRequest req)
        {
            return InternalRequestAsync<DescribePolicyGroupListResponse>(req, "DescribePolicyGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of product events by page.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public Task<DescribeProductEventListResponse> DescribeProductEventList(DescribeProductEventListRequest req)
        {
            return InternalRequestAsync<DescribeProductEventListResponse>(req, "DescribeProductEventList");
        }

        /// <summary>
        /// This API is used to get the list of product events by page.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public DescribeProductEventListResponse DescribeProductEventListSync(DescribeProductEventListRequest req)
        {
            return InternalRequestAsync<DescribeProductEventListResponse>(req, "DescribeProductEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of instances associated with the target cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentInstancesResponse"/></returns>
        public Task<DescribePrometheusAgentInstancesResponse> DescribePrometheusAgentInstances(DescribePrometheusAgentInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentInstancesResponse>(req, "DescribePrometheusAgentInstances");
        }

        /// <summary>
        /// This API is used to get the list of instances associated with the target cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentInstancesResponse"/></returns>
        public DescribePrometheusAgentInstancesResponse DescribePrometheusAgentInstancesSync(DescribePrometheusAgentInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentInstancesResponse>(req, "DescribePrometheusAgentInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list Prometheus CVM agents.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentsResponse"/></returns>
        public Task<DescribePrometheusAgentsResponse> DescribePrometheusAgents(DescribePrometheusAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentsResponse>(req, "DescribePrometheusAgents");
        }

        /// <summary>
        /// This API is used to list Prometheus CVM agents.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentsResponse"/></returns>
        public DescribePrometheusAgentsResponse DescribePrometheusAgentsSync(DescribePrometheusAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentsResponse>(req, "DescribePrometheusAgents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of v2.0 instance alerting rules.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertPolicyResponse"/></returns>
        public Task<DescribePrometheusAlertPolicyResponse> DescribePrometheusAlertPolicy(DescribePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertPolicyResponse>(req, "DescribePrometheusAlertPolicy");
        }

        /// <summary>
        /// This API is used to get the list of v2.0 instance alerting rules.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertPolicyResponse"/></returns>
        public DescribePrometheusAlertPolicyResponse DescribePrometheusAlertPolicySync(DescribePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertPolicyResponse>(req, "DescribePrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of clusters associated with the TMP instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusClusterAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusClusterAgentsResponse"/></returns>
        public Task<DescribePrometheusClusterAgentsResponse> DescribePrometheusClusterAgents(DescribePrometheusClusterAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusClusterAgentsResponse>(req, "DescribePrometheusClusterAgents");
        }

        /// <summary>
        /// This API is used to get the list of clusters associated with the TMP instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusClusterAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusClusterAgentsResponse"/></returns>
        public DescribePrometheusClusterAgentsResponse DescribePrometheusClusterAgentsSync(DescribePrometheusClusterAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusClusterAgentsResponse>(req, "DescribePrometheusClusterAgents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the Prometheus configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusConfigResponse"/></returns>
        public Task<DescribePrometheusConfigResponse> DescribePrometheusConfig(DescribePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusConfigResponse>(req, "DescribePrometheusConfig");
        }

        /// <summary>
        /// This API is used to get the Prometheus configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusConfigResponse"/></returns>
        public DescribePrometheusConfigResponse DescribePrometheusConfigSync(DescribePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusConfigResponse>(req, "DescribePrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the instance-level scrape configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalConfigResponse"/></returns>
        public Task<DescribePrometheusGlobalConfigResponse> DescribePrometheusGlobalConfig(DescribePrometheusGlobalConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalConfigResponse>(req, "DescribePrometheusGlobalConfig");
        }

        /// <summary>
        /// This API is used to get the instance-level scrape configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalConfigResponse"/></returns>
        public DescribePrometheusGlobalConfigResponse DescribePrometheusGlobalConfigSync(DescribePrometheusGlobalConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalConfigResponse>(req, "DescribePrometheusGlobalConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalNotificationResponse"/></returns>
        public Task<DescribePrometheusGlobalNotificationResponse> DescribePrometheusGlobalNotification(DescribePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalNotificationResponse>(req, "DescribePrometheusGlobalNotification");
        }

        /// <summary>
        /// This API is used to query the global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalNotificationResponse"/></returns>
        public DescribePrometheusGlobalNotificationResponse DescribePrometheusGlobalNotificationSync(DescribePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalNotificationResponse>(req, "DescribePrometheusGlobalNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of a TMP instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceDetailResponse"/></returns>
        public Task<DescribePrometheusInstanceDetailResponse> DescribePrometheusInstanceDetail(DescribePrometheusInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceDetailResponse>(req, "DescribePrometheusInstanceDetail");
        }

        /// <summary>
        /// This API is used to get the details of a TMP instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceDetailResponse"/></returns>
        public DescribePrometheusInstanceDetailResponse DescribePrometheusInstanceDetailSync(DescribePrometheusInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceDetailResponse>(req, "DescribePrometheusInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the initialization task status of a v2.0 instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceInitStatusRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceInitStatusResponse"/></returns>
        public Task<DescribePrometheusInstanceInitStatusResponse> DescribePrometheusInstanceInitStatus(DescribePrometheusInstanceInitStatusRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceInitStatusResponse>(req, "DescribePrometheusInstanceInitStatus");
        }

        /// <summary>
        /// This API is used to get the initialization task status of a v2.0 instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceInitStatusRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceInitStatusResponse"/></returns>
        public DescribePrometheusInstanceInitStatusResponse DescribePrometheusInstanceInitStatusSync(DescribePrometheusInstanceInitStatusRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceInitStatusResponse>(req, "DescribePrometheusInstanceInitStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  This API is used to query the usage of a pay-as-you-go Tencent Managed Service for Prometheus (TMP) instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceUsageRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceUsageResponse"/></returns>
        public Task<DescribePrometheusInstanceUsageResponse> DescribePrometheusInstanceUsage(DescribePrometheusInstanceUsageRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceUsageResponse>(req, "DescribePrometheusInstanceUsage");
        }

        /// <summary>
        ///  This API is used to query the usage of a pay-as-you-go Tencent Managed Service for Prometheus (TMP) instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceUsageRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceUsageResponse"/></returns>
        public DescribePrometheusInstanceUsageResponse DescribePrometheusInstanceUsageSync(DescribePrometheusInstanceUsageRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceUsageResponse>(req, "DescribePrometheusInstanceUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of one or multiple instances.
        /// <ul>
        /// <li>You can query the details of an instance by its ID, name, or status.</li>
        /// <li>If this parameter is empty, the information of a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.</li>
        /// </ul>
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesResponse"/></returns>
        public Task<DescribePrometheusInstancesResponse> DescribePrometheusInstances(DescribePrometheusInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstancesResponse>(req, "DescribePrometheusInstances");
        }

        /// <summary>
        /// This API is used to query the details of one or multiple instances.
        /// <ul>
        /// <li>You can query the details of an instance by its ID, name, or status.</li>
        /// <li>If this parameter is empty, the information of a certain number of instances under the current account will be returned. The number is specified by `Limit` and is 20 by default.</li>
        /// </ul>
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesResponse"/></returns>
        public DescribePrometheusInstancesResponse DescribePrometheusInstancesSync(DescribePrometheusInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstancesResponse>(req, "DescribePrometheusInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of Tencent Managed Service for Prometheus (TMP) instances and the clusters associated with them.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesOverviewRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesOverviewResponse"/></returns>
        public Task<DescribePrometheusInstancesOverviewResponse> DescribePrometheusInstancesOverview(DescribePrometheusInstancesOverviewRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstancesOverviewResponse>(req, "DescribePrometheusInstancesOverview");
        }

        /// <summary>
        /// This API is used to obtain the list of Tencent Managed Service for Prometheus (TMP) instances and the clusters associated with them.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesOverviewRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesOverviewResponse"/></returns>
        public DescribePrometheusInstancesOverviewResponse DescribePrometheusInstancesOverviewSync(DescribePrometheusInstancesOverviewRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstancesOverviewResponse>(req, "DescribePrometheusInstancesOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the YAML list of Prometheus recording rules.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRuleYamlResponse"/></returns>
        public Task<DescribePrometheusRecordRuleYamlResponse> DescribePrometheusRecordRuleYaml(DescribePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRecordRuleYamlResponse>(req, "DescribePrometheusRecordRuleYaml");
        }

        /// <summary>
        /// This API is used to get the YAML list of Prometheus recording rules.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRuleYamlResponse"/></returns>
        public DescribePrometheusRecordRuleYamlResponse DescribePrometheusRecordRuleYamlSync(DescribePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRecordRuleYamlResponse>(req, "DescribePrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of recording rules, including those created by CRD resources in the associated cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRulesRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRulesResponse"/></returns>
        public Task<DescribePrometheusRecordRulesResponse> DescribePrometheusRecordRules(DescribePrometheusRecordRulesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRecordRulesResponse>(req, "DescribePrometheusRecordRules");
        }

        /// <summary>
        /// This API is used to get the list of recording rules, including those created by CRD resources in the associated cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRulesRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRulesResponse"/></returns>
        public DescribePrometheusRecordRulesResponse DescribePrometheusRecordRulesSync(DescribePrometheusRecordRulesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRecordRulesResponse>(req, "DescribePrometheusRecordRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list Prometheus scrape tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DescribePrometheusScrapeJobsResponse"/></returns>
        public Task<DescribePrometheusScrapeJobsResponse> DescribePrometheusScrapeJobs(DescribePrometheusScrapeJobsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusScrapeJobsResponse>(req, "DescribePrometheusScrapeJobs");
        }

        /// <summary>
        /// This API is used to list Prometheus scrape tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DescribePrometheusScrapeJobsResponse"/></returns>
        public DescribePrometheusScrapeJobsResponse DescribePrometheusScrapeJobsSync(DescribePrometheusScrapeJobsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusScrapeJobsResponse>(req, "DescribePrometheusScrapeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the targets information.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTargetsTMPRequest"/></param>
        /// <returns><see cref="DescribePrometheusTargetsTMPResponse"/></returns>
        public Task<DescribePrometheusTargetsTMPResponse> DescribePrometheusTargetsTMP(DescribePrometheusTargetsTMPRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTargetsTMPResponse>(req, "DescribePrometheusTargetsTMP");
        }

        /// <summary>
        /// This API is used to get the targets information.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTargetsTMPRequest"/></param>
        /// <returns><see cref="DescribePrometheusTargetsTMPResponse"/></returns>
        public DescribePrometheusTargetsTMPResponse DescribePrometheusTargetsTMPSync(DescribePrometheusTargetsTMPRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTargetsTMPResponse>(req, "DescribePrometheusTargetsTMP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of templates, where the default template is always on top.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempResponse"/></returns>
        public Task<DescribePrometheusTempResponse> DescribePrometheusTemp(DescribePrometheusTempRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempResponse>(req, "DescribePrometheusTemp");
        }

        /// <summary>
        /// This API is used to get the list of templates, where the default template is always on top.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempResponse"/></returns>
        public DescribePrometheusTempResponse DescribePrometheusTempSync(DescribePrometheusTempRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempResponse>(req, "DescribePrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of instances associated with a template. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempSyncResponse"/></returns>
        public Task<DescribePrometheusTempSyncResponse> DescribePrometheusTempSync(DescribePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempSyncResponse>(req, "DescribePrometheusTempSync");
        }

        /// <summary>
        /// This API is used to get the information of instances associated with a template. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempSyncResponse"/></returns>
        public DescribePrometheusTempSyncResponse DescribePrometheusTempSyncSync(DescribePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempSyncResponse>(req, "DescribePrometheusTempSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list the AZs of Tencent Managed Service for Prometheus (TMP).
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusZonesRequest"/></param>
        /// <returns><see cref="DescribePrometheusZonesResponse"/></returns>
        public Task<DescribePrometheusZonesResponse> DescribePrometheusZones(DescribePrometheusZonesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusZonesResponse>(req, "DescribePrometheusZones");
        }

        /// <summary>
        /// This API is used to list the AZs of Tencent Managed Service for Prometheus (TMP).
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusZonesRequest"/></param>
        /// <returns><see cref="DescribePrometheusZonesResponse"/></returns>
        public DescribePrometheusZonesResponse DescribePrometheusZonesSync(DescribePrometheusZonesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusZonesResponse>(req, "DescribePrometheusZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Prometheus recording rules by filter.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingRulesRequest"/></param>
        /// <returns><see cref="DescribeRecordingRulesResponse"/></returns>
        public Task<DescribeRecordingRulesResponse> DescribeRecordingRules(DescribeRecordingRulesRequest req)
        {
            return InternalRequestAsync<DescribeRecordingRulesResponse>(req, "DescribeRecordingRules");
        }

        /// <summary>
        /// This API is used to query Prometheus recording rules by filter.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingRulesRequest"/></param>
        /// <returns><see cref="DescribeRecordingRulesResponse"/></returns>
        public DescribeRecordingRulesResponse DescribeRecordingRulesSync(DescribeRecordingRulesRequest req)
        {
            return InternalRequestAsync<DescribeRecordingRulesResponse>(req, "DescribeRecordingRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list all authorized accounts of the current Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSSOAccountRequest"/></param>
        /// <returns><see cref="DescribeSSOAccountResponse"/></returns>
        public Task<DescribeSSOAccountResponse> DescribeSSOAccount(DescribeSSOAccountRequest req)
        {
            return InternalRequestAsync<DescribeSSOAccountResponse>(req, "DescribeSSOAccount");
        }

        /// <summary>
        /// This API is used to list all authorized accounts of the current Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSSOAccountRequest"/></param>
        /// <returns><see cref="DescribeSSOAccountResponse"/></returns>
        public DescribeSSOAccountResponse DescribeSSOAccountSync(DescribeSSOAccountRequest req)
        {
            return InternalRequestAsync<DescribeSSOAccountResponse>(req, "DescribeSSOAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list Prometheus scrape configurations in TKE.
        /// <p>Note: The prerequisite is that the corresponding TKE service has been integrated through the Prometheus console. For more information, see
        /// <a href="https://intl.cloud.tencent.com/document/product/248/48859?from_cn_redirect=1" target="_blank">Agent Management</a>.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceDiscoveryRequest"/></param>
        /// <returns><see cref="DescribeServiceDiscoveryResponse"/></returns>
        public Task<DescribeServiceDiscoveryResponse> DescribeServiceDiscovery(DescribeServiceDiscoveryRequest req)
        {
            return InternalRequestAsync<DescribeServiceDiscoveryResponse>(req, "DescribeServiceDiscovery");
        }

        /// <summary>
        /// This API is used to list Prometheus scrape configurations in TKE.
        /// <p>Note: The prerequisite is that the corresponding TKE service has been integrated through the Prometheus console. For more information, see
        /// <a href="https://intl.cloud.tencent.com/document/product/248/48859?from_cn_redirect=1" target="_blank">Agent Management</a>.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceDiscoveryRequest"/></param>
        /// <returns><see cref="DescribeServiceDiscoveryResponse"/></returns>
        public DescribeServiceDiscoveryResponse DescribeServiceDiscoverySync(DescribeServiceDiscoveryRequest req)
        {
            return InternalRequestAsync<DescribeServiceDiscoveryResponse>(req, "DescribeServiceDiscovery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query monitoring data by dimension conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDataRequest"/></param>
        /// <returns><see cref="DescribeStatisticDataResponse"/></returns>
        public Task<DescribeStatisticDataResponse> DescribeStatisticData(DescribeStatisticDataRequest req)
        {
            return InternalRequestAsync<DescribeStatisticDataResponse>(req, "DescribeStatisticData");
        }

        /// <summary>
        /// This API is used to query monitoring data by dimension conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDataRequest"/></param>
        /// <returns><see cref="DescribeStatisticDataResponse"/></returns>
        public DescribeStatisticDataResponse DescribeStatisticDataSync(DescribeStatisticDataRequest req)
        {
            return InternalRequestAsync<DescribeStatisticDataResponse>(req, "DescribeStatisticData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the data of a Prometheus instance. The specified instance must be terminated first.
        /// </summary>
        /// <param name="req"><see cref="DestroyPrometheusInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrometheusInstanceResponse"/></returns>
        public Task<DestroyPrometheusInstanceResponse> DestroyPrometheusInstance(DestroyPrometheusInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPrometheusInstanceResponse>(req, "DestroyPrometheusInstance");
        }

        /// <summary>
        /// This API is used to delete the data of a Prometheus instance. The specified instance must be terminated first.
        /// </summary>
        /// <param name="req"><see cref="DestroyPrometheusInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrometheusInstanceResponse"/></returns>
        public DestroyPrometheusInstanceResponse DestroyPrometheusInstanceSync(DestroyPrometheusInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPrometheusInstanceResponse>(req, "DestroyPrometheusInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the Grafana public network access.
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaInternetRequest"/></param>
        /// <returns><see cref="EnableGrafanaInternetResponse"/></returns>
        public Task<EnableGrafanaInternetResponse> EnableGrafanaInternet(EnableGrafanaInternetRequest req)
        {
            return InternalRequestAsync<EnableGrafanaInternetResponse>(req, "EnableGrafanaInternet");
        }

        /// <summary>
        /// This API is used to set the Grafana public network access.
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaInternetRequest"/></param>
        /// <returns><see cref="EnableGrafanaInternetResponse"/></returns>
        public EnableGrafanaInternetResponse EnableGrafanaInternetSync(EnableGrafanaInternetRequest req)
        {
            return InternalRequestAsync<EnableGrafanaInternetResponse>(req, "EnableGrafanaInternet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the Grafana SSO through a Tencent Cloud account.
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaSSORequest"/></param>
        /// <returns><see cref="EnableGrafanaSSOResponse"/></returns>
        public Task<EnableGrafanaSSOResponse> EnableGrafanaSSO(EnableGrafanaSSORequest req)
        {
            return InternalRequestAsync<EnableGrafanaSSOResponse>(req, "EnableGrafanaSSO");
        }

        /// <summary>
        /// This API is used to set the Grafana SSO through a Tencent Cloud account.
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaSSORequest"/></param>
        /// <returns><see cref="EnableGrafanaSSOResponse"/></returns>
        public EnableGrafanaSSOResponse EnableGrafanaSSOSync(EnableGrafanaSSORequest req)
        {
            return InternalRequestAsync<EnableGrafanaSSOResponse>(req, "EnableGrafanaSSO")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set whether to enable CAM authentication during SSO.
        /// </summary>
        /// <param name="req"><see cref="EnableSSOCamCheckRequest"/></param>
        /// <returns><see cref="EnableSSOCamCheckResponse"/></returns>
        public Task<EnableSSOCamCheckResponse> EnableSSOCamCheck(EnableSSOCamCheckRequest req)
        {
            return InternalRequestAsync<EnableSSOCamCheckResponse>(req, "EnableSSOCamCheck");
        }

        /// <summary>
        /// This API is used to set whether to enable CAM authentication during SSO.
        /// </summary>
        /// <param name="req"><see cref="EnableSSOCamCheckRequest"/></param>
        /// <returns><see cref="EnableSSOCamCheckResponse"/></returns>
        public EnableSSOCamCheckResponse EnableSSOCamCheckSync(EnableSSOCamCheckRequest req)
        {
            return InternalRequestAsync<EnableSSOCamCheckResponse>(req, "EnableSSOCamCheck")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the monitoring data of Tencent Cloud services except TKE. To pull TKE’s monitoring data, use the [DescribeStatisticData](https://www.tencentcloud.com/document/product/248/39481) API.
        /// You can get the monitoring data of a Tencent Cloud service by passing in its namespace, object dimension description, and monitoring metrics.
        /// API call rate limit: 20 calls/second (1,200 calls/minute). A single request can get the data of up to 10 instances for up to 1,440 data points.
        /// If you need to call a large number of APIs to pull metrics or objects at a time, some APIs may fail to be called due to the rate limit. We suggest you evenly arrange API calls at a time granularity.
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public Task<GetMonitorDataResponse> GetMonitorData(GetMonitorDataRequest req)
        {
            return InternalRequestAsync<GetMonitorDataResponse>(req, "GetMonitorData");
        }

        /// <summary>
        /// This API is used to get the monitoring data of Tencent Cloud services except TKE. To pull TKE’s monitoring data, use the [DescribeStatisticData](https://www.tencentcloud.com/document/product/248/39481) API.
        /// You can get the monitoring data of a Tencent Cloud service by passing in its namespace, object dimension description, and monitoring metrics.
        /// API call rate limit: 20 calls/second (1,200 calls/minute). A single request can get the data of up to 10 instances for up to 1,440 data points.
        /// If you need to call a large number of APIs to pull metrics or objects at a time, some APIs may fail to be called due to the rate limit. We suggest you evenly arrange API calls at a time granularity.
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public GetMonitorDataResponse GetMonitorDataSync(GetMonitorDataRequest req)
        {
            return InternalRequestAsync<GetMonitorDataResponse>(req, "GetMonitorData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the command line for Prometheus agent management.
        /// </summary>
        /// <param name="req"><see cref="GetPrometheusAgentManagementCommandRequest"/></param>
        /// <returns><see cref="GetPrometheusAgentManagementCommandResponse"/></returns>
        public Task<GetPrometheusAgentManagementCommandResponse> GetPrometheusAgentManagementCommand(GetPrometheusAgentManagementCommandRequest req)
        {
            return InternalRequestAsync<GetPrometheusAgentManagementCommandResponse>(req, "GetPrometheusAgentManagementCommand");
        }

        /// <summary>
        /// This API is used to get the command line for Prometheus agent management.
        /// </summary>
        /// <param name="req"><see cref="GetPrometheusAgentManagementCommandRequest"/></param>
        /// <returns><see cref="GetPrometheusAgentManagementCommandResponse"/></returns>
        public GetPrometheusAgentManagementCommandResponse GetPrometheusAgentManagementCommandSync(GetPrometheusAgentManagementCommandRequest req)
        {
            return InternalRequestAsync<GetPrometheusAgentManagementCommandResponse>(req, "GetPrometheusAgentManagementCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to install a Grafana plugin.
        /// </summary>
        /// <param name="req"><see cref="InstallPluginsRequest"/></param>
        /// <returns><see cref="InstallPluginsResponse"/></returns>
        public Task<InstallPluginsResponse> InstallPlugins(InstallPluginsRequest req)
        {
            return InternalRequestAsync<InstallPluginsResponse>(req, "InstallPlugins");
        }

        /// <summary>
        /// This API is used to install a Grafana plugin.
        /// </summary>
        /// <param name="req"><see cref="InstallPluginsRequest"/></param>
        /// <returns><see cref="InstallPluginsResponse"/></returns>
        public InstallPluginsResponse InstallPluginsSync(InstallPluginsRequest req)
        {
            return InternalRequestAsync<InstallPluginsResponse>(req, "InstallPlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public Task<ModifyAlarmNoticeResponse> ModifyAlarmNotice(ModifyAlarmNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmNoticeResponse>(req, "ModifyAlarmNotice");
        }

        /// <summary>
        /// This API is used to edit an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public ModifyAlarmNoticeResponse ModifyAlarmNoticeSync(ModifyAlarmNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmNoticeResponse>(req, "ModifyAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the trigger condition of an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyConditionRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyConditionResponse"/></returns>
        public Task<ModifyAlarmPolicyConditionResponse> ModifyAlarmPolicyCondition(ModifyAlarmPolicyConditionRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyConditionResponse>(req, "ModifyAlarmPolicyCondition");
        }

        /// <summary>
        /// This API is used to modify the trigger condition of an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyConditionRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyConditionResponse"/></returns>
        public ModifyAlarmPolicyConditionResponse ModifyAlarmPolicyConditionSync(ModifyAlarmPolicyConditionRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyConditionResponse>(req, "ModifyAlarmPolicyCondition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit the basic information of a v2.0 alarm policy, including policy name and remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyInfoRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyInfoResponse"/></returns>
        public Task<ModifyAlarmPolicyInfoResponse> ModifyAlarmPolicyInfo(ModifyAlarmPolicyInfoRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyInfoResponse>(req, "ModifyAlarmPolicyInfo");
        }

        /// <summary>
        /// This API is used to edit the basic information of a v2.0 alarm policy, including policy name and remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyInfoRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyInfoResponse"/></returns>
        public ModifyAlarmPolicyInfoResponse ModifyAlarmPolicyInfoSync(ModifyAlarmPolicyInfoRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyInfoResponse>(req, "ModifyAlarmPolicyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the alarm notification template bound to an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyNoticeResponse"/></returns>
        public Task<ModifyAlarmPolicyNoticeResponse> ModifyAlarmPolicyNotice(ModifyAlarmPolicyNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyNoticeResponse>(req, "ModifyAlarmPolicyNotice");
        }

        /// <summary>
        /// This API is used to modify the alarm notification template bound to an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyNoticeResponse"/></returns>
        public ModifyAlarmPolicyNoticeResponse ModifyAlarmPolicyNoticeSync(ModifyAlarmPolicyNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyNoticeResponse>(req, "ModifyAlarmPolicyNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable/disable an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyStatusResponse"/></returns>
        public Task<ModifyAlarmPolicyStatusResponse> ModifyAlarmPolicyStatus(ModifyAlarmPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyStatusResponse>(req, "ModifyAlarmPolicyStatus");
        }

        /// <summary>
        /// This API is used to enable/disable an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyStatusResponse"/></returns>
        public ModifyAlarmPolicyStatusResponse ModifyAlarmPolicyStatusSync(ModifyAlarmPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyStatusResponse>(req, "ModifyAlarmPolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the tasks triggered by alarm policy, which are listed by the value of the `TriggerTasks` field. If an empty array is passed in for `TriggerTasks`, it means unbinding all the trigger tasks from the policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyTasksRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyTasksResponse"/></returns>
        public Task<ModifyAlarmPolicyTasksResponse> ModifyAlarmPolicyTasks(ModifyAlarmPolicyTasksRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyTasksResponse>(req, "ModifyAlarmPolicyTasks");
        }

        /// <summary>
        /// This API is used to modify the tasks triggered by alarm policy, which are listed by the value of the `TriggerTasks` field. If an empty array is passed in for `TriggerTasks`, it means unbinding all the trigger tasks from the policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyTasksRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyTasksResponse"/></returns>
        public ModifyAlarmPolicyTasksResponse ModifyAlarmPolicyTasksSync(ModifyAlarmPolicyTasksRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyTasksResponse>(req, "ModifyAlarmPolicyTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify alarm recipients.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public Task<ModifyAlarmReceiversResponse> ModifyAlarmReceivers(ModifyAlarmReceiversRequest req)
        {
            return InternalRequestAsync<ModifyAlarmReceiversResponse>(req, "ModifyAlarmReceivers");
        }

        /// <summary>
        /// This API is used to modify alarm recipients.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public ModifyAlarmReceiversResponse ModifyAlarmReceiversSync(ModifyAlarmReceiversRequest req)
        {
            return InternalRequestAsync<ModifyAlarmReceiversResponse>(req, "ModifyAlarmReceivers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ModifyGrafanaInstanceResponse"/></returns>
        public Task<ModifyGrafanaInstanceResponse> ModifyGrafanaInstance(ModifyGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<ModifyGrafanaInstanceResponse>(req, "ModifyGrafanaInstance");
        }

        /// <summary>
        /// This API is used to modify the attributes of a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ModifyGrafanaInstanceResponse"/></returns>
        public ModifyGrafanaInstanceResponse ModifyGrafanaInstanceSync(ModifyGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<ModifyGrafanaInstanceResponse>(req, "ModifyGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update policy group.
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public Task<ModifyPolicyGroupResponse> ModifyPolicyGroup(ModifyPolicyGroupRequest req)
        {
            return InternalRequestAsync<ModifyPolicyGroupResponse>(req, "ModifyPolicyGroup");
        }

        /// <summary>
        /// This API is used to update policy group.
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public ModifyPolicyGroupResponse ModifyPolicyGroupSync(ModifyPolicyGroupRequest req)
        {
            return InternalRequestAsync<ModifyPolicyGroupResponse>(req, "ModifyPolicyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the external labels of the associated cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAgentExternalLabelsRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAgentExternalLabelsResponse"/></returns>
        public Task<ModifyPrometheusAgentExternalLabelsResponse> ModifyPrometheusAgentExternalLabels(ModifyPrometheusAgentExternalLabelsRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAgentExternalLabelsResponse>(req, "ModifyPrometheusAgentExternalLabels");
        }

        /// <summary>
        /// This API is used to modify the external labels of the associated cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAgentExternalLabelsRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAgentExternalLabelsResponse"/></returns>
        public ModifyPrometheusAgentExternalLabelsResponse ModifyPrometheusAgentExternalLabelsSync(ModifyPrometheusAgentExternalLabelsRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAgentExternalLabelsResponse>(req, "ModifyPrometheusAgentExternalLabels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a TMP 2.0 instance alerting rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertPolicyResponse"/></returns>
        public Task<ModifyPrometheusAlertPolicyResponse> ModifyPrometheusAlertPolicy(ModifyPrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAlertPolicyResponse>(req, "ModifyPrometheusAlertPolicy");
        }

        /// <summary>
        /// This API is used to modify a TMP 2.0 instance alerting rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertPolicyResponse"/></returns>
        public ModifyPrometheusAlertPolicyResponse ModifyPrometheusAlertPolicySync(ModifyPrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAlertPolicyResponse>(req, "ModifyPrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the Prometheus configuration. If there are no configuration items, one will be added.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusConfigRequest"/></param>
        /// <returns><see cref="ModifyPrometheusConfigResponse"/></returns>
        public Task<ModifyPrometheusConfigResponse> ModifyPrometheusConfig(ModifyPrometheusConfigRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusConfigResponse>(req, "ModifyPrometheusConfig");
        }

        /// <summary>
        /// This API is used to modify the Prometheus configuration. If there are no configuration items, one will be added.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusConfigRequest"/></param>
        /// <returns><see cref="ModifyPrometheusConfigResponse"/></returns>
        public ModifyPrometheusConfigResponse ModifyPrometheusConfigSync(ModifyPrometheusConfigRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusConfigResponse>(req, "ModifyPrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="ModifyPrometheusGlobalNotificationResponse"/></returns>
        public Task<ModifyPrometheusGlobalNotificationResponse> ModifyPrometheusGlobalNotification(ModifyPrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusGlobalNotificationResponse>(req, "ModifyPrometheusGlobalNotification");
        }

        /// <summary>
        /// This API is used to modify the global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="ModifyPrometheusGlobalNotificationResponse"/></returns>
        public ModifyPrometheusGlobalNotificationResponse ModifyPrometheusGlobalNotificationSync(ModifyPrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusGlobalNotificationResponse>(req, "ModifyPrometheusGlobalNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyPrometheusInstanceAttributesResponse"/></returns>
        public Task<ModifyPrometheusInstanceAttributesResponse> ModifyPrometheusInstanceAttributes(ModifyPrometheusInstanceAttributesRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusInstanceAttributesResponse>(req, "ModifyPrometheusInstanceAttributes");
        }

        /// <summary>
        /// This API is used to modify the attributes of a Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyPrometheusInstanceAttributesResponse"/></returns>
        public ModifyPrometheusInstanceAttributesResponse ModifyPrometheusInstanceAttributesSync(ModifyPrometheusInstanceAttributesRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusInstanceAttributesResponse>(req, "ModifyPrometheusInstanceAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a Prometheus recording instance through YAML.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="ModifyPrometheusRecordRuleYamlResponse"/></returns>
        public Task<ModifyPrometheusRecordRuleYamlResponse> ModifyPrometheusRecordRuleYaml(ModifyPrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusRecordRuleYamlResponse>(req, "ModifyPrometheusRecordRuleYaml");
        }

        /// <summary>
        /// This API is used to modify a Prometheus recording instance through YAML.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="ModifyPrometheusRecordRuleYamlResponse"/></returns>
        public ModifyPrometheusRecordRuleYamlResponse ModifyPrometheusRecordRuleYamlSync(ModifyPrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusRecordRuleYamlResponse>(req, "ModifyPrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a template.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTempRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTempResponse"/></returns>
        public Task<ModifyPrometheusTempResponse> ModifyPrometheusTemp(ModifyPrometheusTempRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusTempResponse>(req, "ModifyPrometheusTemp");
        }

        /// <summary>
        /// This API is used to modify a template.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTempRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTempResponse"/></returns>
        public ModifyPrometheusTempResponse ModifyPrometheusTempSync(ModifyPrometheusTempRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusTempResponse>(req, "ModifyPrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to renew a monthly subscribed TCMG instance for a month without changing the instance edition. It doesn't apply to running instances.
        /// </summary>
        /// <param name="req"><see cref="ResumeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ResumeGrafanaInstanceResponse"/></returns>
        public Task<ResumeGrafanaInstanceResponse> ResumeGrafanaInstance(ResumeGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<ResumeGrafanaInstanceResponse>(req, "ResumeGrafanaInstance");
        }

        /// <summary>
        /// This API is used to renew a monthly subscribed TCMG instance for a month without changing the instance edition. It doesn't apply to running instances.
        /// </summary>
        /// <param name="req"><see cref="ResumeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ResumeGrafanaInstanceResponse"/></returns>
        public ResumeGrafanaInstanceResponse ResumeGrafanaInstanceSync(ResumeGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<ResumeGrafanaInstanceResponse>(req, "ResumeGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initialize a TMP instance, which is called when the integration center is enabled.
        /// </summary>
        /// <param name="req"><see cref="RunPrometheusInstanceRequest"/></param>
        /// <returns><see cref="RunPrometheusInstanceResponse"/></returns>
        public Task<RunPrometheusInstanceResponse> RunPrometheusInstance(RunPrometheusInstanceRequest req)
        {
            return InternalRequestAsync<RunPrometheusInstanceResponse>(req, "RunPrometheusInstance");
        }

        /// <summary>
        /// This API is used to initialize a TMP instance, which is called when the integration center is enabled.
        /// </summary>
        /// <param name="req"><see cref="RunPrometheusInstanceRequest"/></param>
        /// <returns><see cref="RunPrometheusInstanceResponse"/></returns>
        public RunPrometheusInstanceResponse RunPrometheusInstanceSync(RunPrometheusInstanceRequest req)
        {
            return InternalRequestAsync<RunPrometheusInstanceResponse>(req, "RunPrometheusInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send a custom alarm notification.
        /// </summary>
        /// <param name="req"><see cref="SendCustomAlarmMsgRequest"/></param>
        /// <returns><see cref="SendCustomAlarmMsgResponse"/></returns>
        public Task<SendCustomAlarmMsgResponse> SendCustomAlarmMsg(SendCustomAlarmMsgRequest req)
        {
            return InternalRequestAsync<SendCustomAlarmMsgResponse>(req, "SendCustomAlarmMsg");
        }

        /// <summary>
        /// This API is used to send a custom alarm notification.
        /// </summary>
        /// <param name="req"><see cref="SendCustomAlarmMsgRequest"/></param>
        /// <returns><see cref="SendCustomAlarmMsgResponse"/></returns>
        public SendCustomAlarmMsgResponse SendCustomAlarmMsgSync(SendCustomAlarmMsgRequest req)
        {
            return InternalRequestAsync<SendCustomAlarmMsgResponse>(req, "SendCustomAlarmMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set an alarm policy as the default policy in the current policy type under the current project.
        /// Alarm policies in the same type under the project will be set as non-default.
        /// </summary>
        /// <param name="req"><see cref="SetDefaultAlarmPolicyRequest"/></param>
        /// <returns><see cref="SetDefaultAlarmPolicyResponse"/></returns>
        public Task<SetDefaultAlarmPolicyResponse> SetDefaultAlarmPolicy(SetDefaultAlarmPolicyRequest req)
        {
            return InternalRequestAsync<SetDefaultAlarmPolicyResponse>(req, "SetDefaultAlarmPolicy");
        }

        /// <summary>
        /// This API is used to set an alarm policy as the default policy in the current policy type under the current project.
        /// Alarm policies in the same type under the project will be set as non-default.
        /// </summary>
        /// <param name="req"><see cref="SetDefaultAlarmPolicyRequest"/></param>
        /// <returns><see cref="SetDefaultAlarmPolicyResponse"/></returns>
        public SetDefaultAlarmPolicyResponse SetDefaultAlarmPolicySync(SetDefaultAlarmPolicyRequest req)
        {
            return InternalRequestAsync<SetDefaultAlarmPolicyResponse>(req, "SetDefaultAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to sync a template to an instance or cluster. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTempRequest"/></param>
        /// <returns><see cref="SyncPrometheusTempResponse"/></returns>
        public Task<SyncPrometheusTempResponse> SyncPrometheusTemp(SyncPrometheusTempRequest req)
        {
            return InternalRequestAsync<SyncPrometheusTempResponse>(req, "SyncPrometheusTemp");
        }

        /// <summary>
        /// This API is used to sync a template to an instance or cluster. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTempRequest"/></param>
        /// <returns><see cref="SyncPrometheusTempResponse"/></returns>
        public SyncPrometheusTempResponse SyncPrometheusTempSync(SyncPrometheusTempRequest req)
        {
            return InternalRequestAsync<SyncPrometheusTempResponse>(req, "SyncPrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="TerminatePrometheusInstancesRequest"/></param>
        /// <returns><see cref="TerminatePrometheusInstancesResponse"/></returns>
        public Task<TerminatePrometheusInstancesResponse> TerminatePrometheusInstances(TerminatePrometheusInstancesRequest req)
        {
            return InternalRequestAsync<TerminatePrometheusInstancesResponse>(req, "TerminatePrometheusInstances");
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="TerminatePrometheusInstancesRequest"/></param>
        /// <returns><see cref="TerminatePrometheusInstancesResponse"/></returns>
        public TerminatePrometheusInstancesResponse TerminatePrometheusInstancesSync(TerminatePrometheusInstancesRequest req)
        {
            return InternalRequestAsync<TerminatePrometheusInstancesResponse>(req, "TerminatePrometheusInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete all bound objects.
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public Task<UnBindingAllPolicyObjectResponse> UnBindingAllPolicyObject(UnBindingAllPolicyObjectRequest req)
        {
            return InternalRequestAsync<UnBindingAllPolicyObjectResponse>(req, "UnBindingAllPolicyObject");
        }

        /// <summary>
        /// This API is used to delete all bound objects.
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public UnBindingAllPolicyObjectResponse UnBindingAllPolicyObjectSync(UnBindingAllPolicyObjectRequest req)
        {
            return InternalRequestAsync<UnBindingAllPolicyObjectResponse>(req, "UnBindingAllPolicyObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an object that is bound to a policy.
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public Task<UnBindingPolicyObjectResponse> UnBindingPolicyObject(UnBindingPolicyObjectRequest req)
        {
            return InternalRequestAsync<UnBindingPolicyObjectResponse>(req, "UnBindingPolicyObject");
        }

        /// <summary>
        /// This API is used to delete an object that is bound to a policy.
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public UnBindingPolicyObjectResponse UnBindingPolicyObjectSync(UnBindingPolicyObjectRequest req)
        {
            return InternalRequestAsync<UnBindingPolicyObjectResponse>(req, "UnBindingPolicyObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a Grafana instance from an instance.
        /// </summary>
        /// <param name="req"><see cref="UnbindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="UnbindPrometheusManagedGrafanaResponse"/></returns>
        public Task<UnbindPrometheusManagedGrafanaResponse> UnbindPrometheusManagedGrafana(UnbindPrometheusManagedGrafanaRequest req)
        {
            return InternalRequestAsync<UnbindPrometheusManagedGrafanaResponse>(req, "UnbindPrometheusManagedGrafana");
        }

        /// <summary>
        /// This API is used to unbind a Grafana instance from an instance.
        /// </summary>
        /// <param name="req"><see cref="UnbindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="UnbindPrometheusManagedGrafanaResponse"/></returns>
        public UnbindPrometheusManagedGrafanaResponse UnbindPrometheusManagedGrafanaSync(UnbindPrometheusManagedGrafanaRequest req)
        {
            return InternalRequestAsync<UnbindPrometheusManagedGrafanaResponse>(req, "UnbindPrometheusManagedGrafana")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a Grafana dashboard.
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UninstallGrafanaDashboardResponse"/></returns>
        public Task<UninstallGrafanaDashboardResponse> UninstallGrafanaDashboard(UninstallGrafanaDashboardRequest req)
        {
            return InternalRequestAsync<UninstallGrafanaDashboardResponse>(req, "UninstallGrafanaDashboard");
        }

        /// <summary>
        /// This API is used to delete a Grafana dashboard.
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UninstallGrafanaDashboardResponse"/></returns>
        public UninstallGrafanaDashboardResponse UninstallGrafanaDashboardSync(UninstallGrafanaDashboardRequest req)
        {
            return InternalRequestAsync<UninstallGrafanaDashboardResponse>(req, "UninstallGrafanaDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete installed plugins.
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaPluginsRequest"/></param>
        /// <returns><see cref="UninstallGrafanaPluginsResponse"/></returns>
        public Task<UninstallGrafanaPluginsResponse> UninstallGrafanaPlugins(UninstallGrafanaPluginsRequest req)
        {
            return InternalRequestAsync<UninstallGrafanaPluginsResponse>(req, "UninstallGrafanaPlugins");
        }

        /// <summary>
        /// This API is used to delete installed plugins.
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaPluginsRequest"/></param>
        /// <returns><see cref="UninstallGrafanaPluginsResponse"/></returns>
        public UninstallGrafanaPluginsResponse UninstallGrafanaPluginsSync(UninstallGrafanaPluginsRequest req)
        {
            return InternalRequestAsync<UninstallGrafanaPluginsResponse>(req, "UninstallGrafanaPlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a Prometheus alerting rule.
        /// 
        /// Note that alert object and alert message are special fields of Prometheus Rule Annotations, which need to be passed in through `annotations` and correspond to `summary` and `description` keys respectively. For more information, see [Alerting rules](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/).
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleResponse"/></returns>
        public Task<UpdateAlertRuleResponse> UpdateAlertRule(UpdateAlertRuleRequest req)
        {
            return InternalRequestAsync<UpdateAlertRuleResponse>(req, "UpdateAlertRule");
        }

        /// <summary>
        /// This API is used to update a Prometheus alerting rule.
        /// 
        /// Note that alert object and alert message are special fields of Prometheus Rule Annotations, which need to be passed in through `annotations` and correspond to `summary` and `description` keys respectively. For more information, see [Alerting rules](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/).
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleResponse"/></returns>
        public UpdateAlertRuleResponse UpdateAlertRuleSync(UpdateAlertRuleRequest req)
        {
            return InternalRequestAsync<UpdateAlertRuleResponse>(req, "UpdateAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the status of a Prometheus alerting rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleStateRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleStateResponse"/></returns>
        public Task<UpdateAlertRuleStateResponse> UpdateAlertRuleState(UpdateAlertRuleStateRequest req)
        {
            return InternalRequestAsync<UpdateAlertRuleStateResponse>(req, "UpdateAlertRuleState");
        }

        /// <summary>
        /// This API is used to update the status of a Prometheus alerting rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleStateRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleStateResponse"/></returns>
        public UpdateAlertRuleStateResponse UpdateAlertRuleStateSync(UpdateAlertRuleStateRequest req)
        {
            return InternalRequestAsync<UpdateAlertRuleStateResponse>(req, "UpdateAlertRuleState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the Grafana DNS configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateDNSConfigRequest"/></param>
        /// <returns><see cref="UpdateDNSConfigResponse"/></returns>
        public Task<UpdateDNSConfigResponse> UpdateDNSConfig(UpdateDNSConfigRequest req)
        {
            return InternalRequestAsync<UpdateDNSConfigResponse>(req, "UpdateDNSConfig");
        }

        /// <summary>
        /// This API is used to update the Grafana DNS configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateDNSConfigRequest"/></param>
        /// <returns><see cref="UpdateDNSConfigResponse"/></returns>
        public UpdateDNSConfigResponse UpdateDNSConfigSync(UpdateDNSConfigRequest req)
        {
            return InternalRequestAsync<UpdateDNSConfigResponse>(req, "UpdateDNSConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the exporter integration configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateExporterIntegrationRequest"/></param>
        /// <returns><see cref="UpdateExporterIntegrationResponse"/></returns>
        public Task<UpdateExporterIntegrationResponse> UpdateExporterIntegration(UpdateExporterIntegrationRequest req)
        {
            return InternalRequestAsync<UpdateExporterIntegrationResponse>(req, "UpdateExporterIntegration");
        }

        /// <summary>
        /// This API is used to update the exporter integration configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateExporterIntegrationRequest"/></param>
        /// <returns><see cref="UpdateExporterIntegrationResponse"/></returns>
        public UpdateExporterIntegrationResponse UpdateExporterIntegrationSync(UpdateExporterIntegrationRequest req)
        {
            return InternalRequestAsync<UpdateExporterIntegrationResponse>(req, "UpdateExporterIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the Grafana configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaConfigRequest"/></param>
        /// <returns><see cref="UpdateGrafanaConfigResponse"/></returns>
        public Task<UpdateGrafanaConfigResponse> UpdateGrafanaConfig(UpdateGrafanaConfigRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaConfigResponse>(req, "UpdateGrafanaConfig");
        }

        /// <summary>
        /// This API is used to update the Grafana configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaConfigRequest"/></param>
        /// <returns><see cref="UpdateGrafanaConfigResponse"/></returns>
        public UpdateGrafanaConfigResponse UpdateGrafanaConfigSync(UpdateGrafanaConfigRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaConfigResponse>(req, "UpdateGrafanaConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update Grafana environment variables.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="UpdateGrafanaEnvironmentsResponse"/></returns>
        public Task<UpdateGrafanaEnvironmentsResponse> UpdateGrafanaEnvironments(UpdateGrafanaEnvironmentsRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaEnvironmentsResponse>(req, "UpdateGrafanaEnvironments");
        }

        /// <summary>
        /// This API is used to update Grafana environment variables.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="UpdateGrafanaEnvironmentsResponse"/></returns>
        public UpdateGrafanaEnvironmentsResponse UpdateGrafanaEnvironmentsSync(UpdateGrafanaEnvironmentsRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaEnvironmentsResponse>(req, "UpdateGrafanaEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="UpdateGrafanaIntegrationResponse"/></returns>
        public Task<UpdateGrafanaIntegrationResponse> UpdateGrafanaIntegration(UpdateGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaIntegrationResponse>(req, "UpdateGrafanaIntegration");
        }

        /// <summary>
        /// This API is used to update the Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="UpdateGrafanaIntegrationResponse"/></returns>
        public UpdateGrafanaIntegrationResponse UpdateGrafanaIntegrationSync(UpdateGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaIntegrationResponse>(req, "UpdateGrafanaIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="UpdateGrafanaNotificationChannelResponse"/></returns>
        public Task<UpdateGrafanaNotificationChannelResponse> UpdateGrafanaNotificationChannel(UpdateGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaNotificationChannelResponse>(req, "UpdateGrafanaNotificationChannel");
        }

        /// <summary>
        /// This API is used to update the Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="UpdateGrafanaNotificationChannelResponse"/></returns>
        public UpdateGrafanaNotificationChannelResponse UpdateGrafanaNotificationChannelSync(UpdateGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaNotificationChannelResponse>(req, "UpdateGrafanaNotificationChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the Grafana allowlist.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="UpdateGrafanaWhiteListResponse"/></returns>
        public Task<UpdateGrafanaWhiteListResponse> UpdateGrafanaWhiteList(UpdateGrafanaWhiteListRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaWhiteListResponse>(req, "UpdateGrafanaWhiteList");
        }

        /// <summary>
        /// This API is used to update the Grafana allowlist.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="UpdateGrafanaWhiteListResponse"/></returns>
        public UpdateGrafanaWhiteListResponse UpdateGrafanaWhiteListSync(UpdateGrafanaWhiteListRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaWhiteListResponse>(req, "UpdateGrafanaWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the status of a Prometheus CVM agent.
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusAgentStatusRequest"/></param>
        /// <returns><see cref="UpdatePrometheusAgentStatusResponse"/></returns>
        public Task<UpdatePrometheusAgentStatusResponse> UpdatePrometheusAgentStatus(UpdatePrometheusAgentStatusRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusAgentStatusResponse>(req, "UpdatePrometheusAgentStatus");
        }

        /// <summary>
        /// This API is used to update the status of a Prometheus CVM agent.
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusAgentStatusRequest"/></param>
        /// <returns><see cref="UpdatePrometheusAgentStatusResponse"/></returns>
        public UpdatePrometheusAgentStatusResponse UpdatePrometheusAgentStatusSync(UpdatePrometheusAgentStatusRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusAgentStatusResponse>(req, "UpdatePrometheusAgentStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="UpdatePrometheusScrapeJobResponse"/></returns>
        public Task<UpdatePrometheusScrapeJobResponse> UpdatePrometheusScrapeJob(UpdatePrometheusScrapeJobRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusScrapeJobResponse>(req, "UpdatePrometheusScrapeJob");
        }

        /// <summary>
        /// This API is used to update a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="UpdatePrometheusScrapeJobResponse"/></returns>
        public UpdatePrometheusScrapeJobResponse UpdatePrometheusScrapeJobSync(UpdatePrometheusScrapeJobRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusScrapeJobResponse>(req, "UpdatePrometheusScrapeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a Prometheus recording rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordingRuleRequest"/></param>
        /// <returns><see cref="UpdateRecordingRuleResponse"/></returns>
        public Task<UpdateRecordingRuleResponse> UpdateRecordingRule(UpdateRecordingRuleRequest req)
        {
            return InternalRequestAsync<UpdateRecordingRuleResponse>(req, "UpdateRecordingRule");
        }

        /// <summary>
        /// This API is used to update a Prometheus recording rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordingRuleRequest"/></param>
        /// <returns><see cref="UpdateRecordingRuleResponse"/></returns>
        public UpdateRecordingRuleResponse UpdateRecordingRuleSync(UpdateRecordingRuleRequest req)
        {
            return InternalRequestAsync<UpdateRecordingRuleResponse>(req, "UpdateRecordingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the remarks and permission information of an authorized account in an overwriting manner.
        /// </summary>
        /// <param name="req"><see cref="UpdateSSOAccountRequest"/></param>
        /// <returns><see cref="UpdateSSOAccountResponse"/></returns>
        public Task<UpdateSSOAccountResponse> UpdateSSOAccount(UpdateSSOAccountRequest req)
        {
            return InternalRequestAsync<UpdateSSOAccountResponse>(req, "UpdateSSOAccount");
        }

        /// <summary>
        /// This API is used to update the remarks and permission information of an authorized account in an overwriting manner.
        /// </summary>
        /// <param name="req"><see cref="UpdateSSOAccountRequest"/></param>
        /// <returns><see cref="UpdateSSOAccountResponse"/></returns>
        public UpdateSSOAccountResponse UpdateSSOAccountSync(UpdateSSOAccountRequest req)
        {
            return InternalRequestAsync<UpdateSSOAccountResponse>(req, "UpdateSSOAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a Grafana dashboard.
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaDashboardResponse"/></returns>
        public Task<UpgradeGrafanaDashboardResponse> UpgradeGrafanaDashboard(UpgradeGrafanaDashboardRequest req)
        {
            return InternalRequestAsync<UpgradeGrafanaDashboardResponse>(req, "UpgradeGrafanaDashboard");
        }

        /// <summary>
        /// This API is used to update a Grafana dashboard.
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaDashboardResponse"/></returns>
        public UpgradeGrafanaDashboardResponse UpgradeGrafanaDashboardSync(UpgradeGrafanaDashboardRequest req)
        {
            return InternalRequestAsync<UpgradeGrafanaDashboardResponse>(req, "UpgradeGrafanaDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaInstanceResponse"/></returns>
        public Task<UpgradeGrafanaInstanceResponse> UpgradeGrafanaInstance(UpgradeGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeGrafanaInstanceResponse>(req, "UpgradeGrafanaInstance");
        }

        /// <summary>
        /// This API is used to upgrade a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaInstanceResponse"/></returns>
        public UpgradeGrafanaInstanceResponse UpgradeGrafanaInstanceSync(UpgradeGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeGrafanaInstanceResponse>(req, "UpgradeGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
