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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MonitorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to bind a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="BindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="BindPrometheusManagedGrafanaResponse"/></returns>
        public async Task<BindPrometheusManagedGrafanaResponse> BindPrometheusManagedGrafana(BindPrometheusManagedGrafanaRequest req)
        {
             JsonResponseModel<BindPrometheusManagedGrafanaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindPrometheusManagedGrafana");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindPrometheusManagedGrafanaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="BindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="BindPrometheusManagedGrafanaResponse"/></returns>
        public BindPrometheusManagedGrafanaResponse BindPrometheusManagedGrafanaSync(BindPrometheusManagedGrafanaRequest req)
        {
             JsonResponseModel<BindPrometheusManagedGrafanaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindPrometheusManagedGrafana");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindPrometheusManagedGrafanaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an alarm policy to a specific object.
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public async Task<BindingPolicyObjectResponse> BindingPolicyObject(BindingPolicyObjectRequest req)
        {
             JsonResponseModel<BindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an alarm policy to a specific object.
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public BindingPolicyObjectResponse BindingPolicyObjectSync(BindingPolicyObjectRequest req)
        {
             JsonResponseModel<BindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to determine whether the user is new to TMP, that is, whether the user has never created a TMP instance in any region.
        /// </summary>
        /// <param name="req"><see cref="CheckIsPrometheusNewUserRequest"/></param>
        /// <returns><see cref="CheckIsPrometheusNewUserResponse"/></returns>
        public async Task<CheckIsPrometheusNewUserResponse> CheckIsPrometheusNewUser(CheckIsPrometheusNewUserRequest req)
        {
             JsonResponseModel<CheckIsPrometheusNewUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckIsPrometheusNewUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIsPrometheusNewUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to determine whether the user is new to TMP, that is, whether the user has never created a TMP instance in any region.
        /// </summary>
        /// <param name="req"><see cref="CheckIsPrometheusNewUserRequest"/></param>
        /// <returns><see cref="CheckIsPrometheusNewUserResponse"/></returns>
        public CheckIsPrometheusNewUserResponse CheckIsPrometheusNewUserSync(CheckIsPrometheusNewUserRequest req)
        {
             JsonResponseModel<CheckIsPrometheusNewUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckIsPrometheusNewUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIsPrometheusNewUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to forcibly terminate a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="CleanGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CleanGrafanaInstanceResponse"/></returns>
        public async Task<CleanGrafanaInstanceResponse> CleanGrafanaInstance(CleanGrafanaInstanceRequest req)
        {
             JsonResponseModel<CleanGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CleanGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CleanGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to forcibly terminate a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="CleanGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CleanGrafanaInstanceResponse"/></returns>
        public CleanGrafanaInstanceResponse CleanGrafanaInstanceSync(CleanGrafanaInstanceRequest req)
        {
             JsonResponseModel<CleanGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CleanGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CleanGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a notification template.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public async Task<CreateAlarmNoticeResponse> CreateAlarmNotice(CreateAlarmNoticeRequest req)
        {
             JsonResponseModel<CreateAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a notification template.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public CreateAlarmNoticeResponse CreateAlarmNoticeSync(CreateAlarmNoticeRequest req)
        {
             JsonResponseModel<CreateAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Cloud Monitor alarm policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmPolicyRequest"/></param>
        /// <returns><see cref="CreateAlarmPolicyResponse"/></returns>
        public async Task<CreateAlarmPolicyResponse> CreateAlarmPolicy(CreateAlarmPolicyRequest req)
        {
             JsonResponseModel<CreateAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Cloud Monitor alarm policy.
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmPolicyRequest"/></param>
        /// <returns><see cref="CreateAlarmPolicyResponse"/></returns>
        public CreateAlarmPolicyResponse CreateAlarmPolicySync(CreateAlarmPolicyRequest req)
        {
             JsonResponseModel<CreateAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Prometheus alerting rule.
        /// 
        /// Note that alert object and alert message are special fields of Prometheus Rule Annotations, which need to be passed in through `annotations` and correspond to `summary` and `description` keys respectively. For more information, see [Alerting rules](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/).
        /// </summary>
        /// <param name="req"><see cref="CreateAlertRuleRequest"/></param>
        /// <returns><see cref="CreateAlertRuleResponse"/></returns>
        public async Task<CreateAlertRuleResponse> CreateAlertRule(CreateAlertRuleRequest req)
        {
             JsonResponseModel<CreateAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an exporter integration.
        /// </summary>
        /// <param name="req"><see cref="CreateExporterIntegrationRequest"/></param>
        /// <returns><see cref="CreateExporterIntegrationResponse"/></returns>
        public async Task<CreateExporterIntegrationResponse> CreateExporterIntegration(CreateExporterIntegrationRequest req)
        {
             JsonResponseModel<CreateExporterIntegrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateExporterIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExporterIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an exporter integration.
        /// </summary>
        /// <param name="req"><see cref="CreateExporterIntegrationRequest"/></param>
        /// <returns><see cref="CreateExporterIntegrationResponse"/></returns>
        public CreateExporterIntegrationResponse CreateExporterIntegrationSync(CreateExporterIntegrationRequest req)
        {
             JsonResponseModel<CreateExporterIntegrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateExporterIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExporterIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CreateGrafanaInstanceResponse"/></returns>
        public async Task<CreateGrafanaInstanceResponse> CreateGrafanaInstance(CreateGrafanaInstanceRequest req)
        {
             JsonResponseModel<CreateGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CreateGrafanaInstanceResponse"/></returns>
        public CreateGrafanaInstanceResponse CreateGrafanaInstanceSync(CreateGrafanaInstanceRequest req)
        {
             JsonResponseModel<CreateGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="CreateGrafanaIntegrationResponse"/></returns>
        public async Task<CreateGrafanaIntegrationResponse> CreateGrafanaIntegration(CreateGrafanaIntegrationRequest req)
        {
             JsonResponseModel<CreateGrafanaIntegrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGrafanaIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGrafanaIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="CreateGrafanaIntegrationResponse"/></returns>
        public CreateGrafanaIntegrationResponse CreateGrafanaIntegrationSync(CreateGrafanaIntegrationRequest req)
        {
             JsonResponseModel<CreateGrafanaIntegrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGrafanaIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGrafanaIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="CreateGrafanaNotificationChannelResponse"/></returns>
        public async Task<CreateGrafanaNotificationChannelResponse> CreateGrafanaNotificationChannel(CreateGrafanaNotificationChannelRequest req)
        {
             JsonResponseModel<CreateGrafanaNotificationChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGrafanaNotificationChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGrafanaNotificationChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="CreateGrafanaNotificationChannelResponse"/></returns>
        public CreateGrafanaNotificationChannelResponse CreateGrafanaNotificationChannelSync(CreateGrafanaNotificationChannelRequest req)
        {
             JsonResponseModel<CreateGrafanaNotificationChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGrafanaNotificationChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGrafanaNotificationChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a policy group.
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public async Task<CreatePolicyGroupResponse> CreatePolicyGroup(CreatePolicyGroupRequest req)
        {
             JsonResponseModel<CreatePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a policy group.
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public CreatePolicyGroupResponse CreatePolicyGroupSync(CreatePolicyGroupRequest req)
        {
             JsonResponseModel<CreatePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Prometheus CVM agent.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusAgentResponse"/></returns>
        public async Task<CreatePrometheusAgentResponse> CreatePrometheusAgent(CreatePrometheusAgentRequest req)
        {
             JsonResponseModel<CreatePrometheusAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Prometheus CVM agent.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusAgentResponse"/></returns>
        public CreatePrometheusAgentResponse CreatePrometheusAgentSync(CreatePrometheusAgentRequest req)
        {
             JsonResponseModel<CreatePrometheusAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an alerting rule.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertPolicyResponse"/></returns>
        public async Task<CreatePrometheusAlertPolicyResponse> CreatePrometheusAlertPolicy(CreatePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<CreatePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an alerting rule.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertPolicyResponse"/></returns>
        public CreatePrometheusAlertPolicyResponse CreatePrometheusAlertPolicySync(CreatePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<CreatePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate a Cloud Monitor (CM)-integrated Tencent Managed Service for Prometheus (TMP) 2.0 instance with a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusClusterAgentResponse"/></returns>
        public async Task<CreatePrometheusClusterAgentResponse> CreatePrometheusClusterAgent(CreatePrometheusClusterAgentRequest req)
        {
             JsonResponseModel<CreatePrometheusClusterAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusClusterAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusClusterAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate a Cloud Monitor (CM)-integrated Tencent Managed Service for Prometheus (TMP) 2.0 instance with a cluster.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusClusterAgentResponse"/></returns>
        public CreatePrometheusClusterAgentResponse CreatePrometheusClusterAgentSync(CreatePrometheusClusterAgentRequest req)
        {
             JsonResponseModel<CreatePrometheusClusterAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusClusterAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusClusterAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create Prometheus configurations.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusConfigRequest"/></param>
        /// <returns><see cref="CreatePrometheusConfigResponse"/></returns>
        public async Task<CreatePrometheusConfigResponse> CreatePrometheusConfig(CreatePrometheusConfigRequest req)
        {
             JsonResponseModel<CreatePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create Prometheus configurations.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusConfigRequest"/></param>
        /// <returns><see cref="CreatePrometheusConfigResponse"/></returns>
        public CreatePrometheusConfigResponse CreatePrometheusConfigSync(CreatePrometheusConfigRequest req)
        {
             JsonResponseModel<CreatePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="CreatePrometheusGlobalNotificationResponse"/></returns>
        public async Task<CreatePrometheusGlobalNotificationResponse> CreatePrometheusGlobalNotification(CreatePrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<CreatePrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="CreatePrometheusGlobalNotificationResponse"/></returns>
        public CreatePrometheusGlobalNotificationResponse CreatePrometheusGlobalNotificationSync(CreatePrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<CreatePrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusMultiTenantInstancePostPayModeRequest"/></param>
        /// <returns><see cref="CreatePrometheusMultiTenantInstancePostPayModeResponse"/></returns>
        public async Task<CreatePrometheusMultiTenantInstancePostPayModeResponse> CreatePrometheusMultiTenantInstancePostPayMode(CreatePrometheusMultiTenantInstancePostPayModeRequest req)
        {
             JsonResponseModel<CreatePrometheusMultiTenantInstancePostPayModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusMultiTenantInstancePostPayMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusMultiTenantInstancePostPayModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusMultiTenantInstancePostPayModeRequest"/></param>
        /// <returns><see cref="CreatePrometheusMultiTenantInstancePostPayModeResponse"/></returns>
        public CreatePrometheusMultiTenantInstancePostPayModeResponse CreatePrometheusMultiTenantInstancePostPayModeSync(CreatePrometheusMultiTenantInstancePostPayModeRequest req)
        {
             JsonResponseModel<CreatePrometheusMultiTenantInstancePostPayModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusMultiTenantInstancePostPayMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusMultiTenantInstancePostPayModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a recording rule in the YAML way.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="CreatePrometheusRecordRuleYamlResponse"/></returns>
        public async Task<CreatePrometheusRecordRuleYamlResponse> CreatePrometheusRecordRuleYaml(CreatePrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<CreatePrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a recording rule in the YAML way.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="CreatePrometheusRecordRuleYamlResponse"/></returns>
        public CreatePrometheusRecordRuleYamlResponse CreatePrometheusRecordRuleYamlSync(CreatePrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<CreatePrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="CreatePrometheusScrapeJobResponse"/></returns>
        public async Task<CreatePrometheusScrapeJobResponse> CreatePrometheusScrapeJob(CreatePrometheusScrapeJobRequest req)
        {
             JsonResponseModel<CreatePrometheusScrapeJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusScrapeJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusScrapeJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="CreatePrometheusScrapeJobResponse"/></returns>
        public CreatePrometheusScrapeJobResponse CreatePrometheusScrapeJobSync(CreatePrometheusScrapeJobRequest req)
        {
             JsonResponseModel<CreatePrometheusScrapeJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusScrapeJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusScrapeJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a TMP template.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTempRequest"/></param>
        /// <returns><see cref="CreatePrometheusTempResponse"/></returns>
        public async Task<CreatePrometheusTempResponse> CreatePrometheusTemp(CreatePrometheusTempRequest req)
        {
             JsonResponseModel<CreatePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a TMP template.
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTempRequest"/></param>
        /// <returns><see cref="CreatePrometheusTempResponse"/></returns>
        public CreatePrometheusTempResponse CreatePrometheusTempSync(CreatePrometheusTempRequest req)
        {
             JsonResponseModel<CreatePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Prometheus recording rule.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingRuleRequest"/></param>
        /// <returns><see cref="CreateRecordingRuleResponse"/></returns>
        public async Task<CreateRecordingRuleResponse> CreateRecordingRule(CreateRecordingRuleRequest req)
        {
             JsonResponseModel<CreateRecordingRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRecordingRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordingRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Prometheus recording rule.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingRuleRequest"/></param>
        /// <returns><see cref="CreateRecordingRuleResponse"/></returns>
        public CreateRecordingRuleResponse CreateRecordingRuleSync(CreateRecordingRuleRequest req)
        {
             JsonResponseModel<CreateRecordingRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRecordingRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordingRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to authorize a Grafana instance to another Tencent Cloud user.
        /// </summary>
        /// <param name="req"><see cref="CreateSSOAccountRequest"/></param>
        /// <returns><see cref="CreateSSOAccountResponse"/></returns>
        public async Task<CreateSSOAccountResponse> CreateSSOAccount(CreateSSOAccountRequest req)
        {
             JsonResponseModel<CreateSSOAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSSOAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSSOAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to authorize a Grafana instance to another Tencent Cloud user.
        /// </summary>
        /// <param name="req"><see cref="CreateSSOAccountRequest"/></param>
        /// <returns><see cref="CreateSSOAccountResponse"/></returns>
        public CreateSSOAccountResponse CreateSSOAccountSync(CreateSSOAccountRequest req)
        {
             JsonResponseModel<CreateSSOAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSSOAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSSOAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Prometheus scrape configuration in TKE.
        /// <p>Note: The prerequisite is that the corresponding TKE service has been integrated through the Prometheus console. For more information, see
        /// <a href="https://intl.cloud.tencent.com/document/product/248/48859?from_cn_redirect=1" target="_blank">Agent Management</a>.</p>
        /// </summary>
        /// <param name="req"><see cref="CreateServiceDiscoveryRequest"/></param>
        /// <returns><see cref="CreateServiceDiscoveryResponse"/></returns>
        public async Task<CreateServiceDiscoveryResponse> CreateServiceDiscovery(CreateServiceDiscoveryRequest req)
        {
             JsonResponseModel<CreateServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete alarm notification templates.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticesRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticesResponse"/></returns>
        public async Task<DeleteAlarmNoticesResponse> DeleteAlarmNotices(DeleteAlarmNoticesRequest req)
        {
             JsonResponseModel<DeleteAlarmNoticesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlarmNotices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmNoticesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete alarm notification templates.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticesRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticesResponse"/></returns>
        public DeleteAlarmNoticesResponse DeleteAlarmNoticesSync(DeleteAlarmNoticesRequest req)
        {
             JsonResponseModel<DeleteAlarmNoticesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlarmNotices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmNoticesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmPolicyRequest"/></param>
        /// <returns><see cref="DeleteAlarmPolicyResponse"/></returns>
        public async Task<DeleteAlarmPolicyResponse> DeleteAlarmPolicy(DeleteAlarmPolicyRequest req)
        {
             JsonResponseModel<DeleteAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmPolicyRequest"/></param>
        /// <returns><see cref="DeleteAlarmPolicyResponse"/></returns>
        public DeleteAlarmPolicyResponse DeleteAlarmPolicySync(DeleteAlarmPolicyRequest req)
        {
             JsonResponseModel<DeleteAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete Prometheus alerting rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertRulesRequest"/></param>
        /// <returns><see cref="DeleteAlertRulesResponse"/></returns>
        public async Task<DeleteAlertRulesResponse> DeleteAlertRules(DeleteAlertRulesRequest req)
        {
             JsonResponseModel<DeleteAlertRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlertRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlertRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete Prometheus alerting rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertRulesRequest"/></param>
        /// <returns><see cref="DeleteAlertRulesResponse"/></returns>
        public DeleteAlertRulesResponse DeleteAlertRulesSync(DeleteAlertRulesRequest req)
        {
             JsonResponseModel<DeleteAlertRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlertRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlertRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an exporter integration.
        /// </summary>
        /// <param name="req"><see cref="DeleteExporterIntegrationRequest"/></param>
        /// <returns><see cref="DeleteExporterIntegrationResponse"/></returns>
        public async Task<DeleteExporterIntegrationResponse> DeleteExporterIntegration(DeleteExporterIntegrationRequest req)
        {
             JsonResponseModel<DeleteExporterIntegrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteExporterIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteExporterIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an exporter integration.
        /// </summary>
        /// <param name="req"><see cref="DeleteExporterIntegrationRequest"/></param>
        /// <returns><see cref="DeleteExporterIntegrationResponse"/></returns>
        public DeleteExporterIntegrationResponse DeleteExporterIntegrationSync(DeleteExporterIntegrationRequest req)
        {
             JsonResponseModel<DeleteExporterIntegrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteExporterIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteExporterIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaInstanceRequest"/></param>
        /// <returns><see cref="DeleteGrafanaInstanceResponse"/></returns>
        public async Task<DeleteGrafanaInstanceResponse> DeleteGrafanaInstance(DeleteGrafanaInstanceRequest req)
        {
             JsonResponseModel<DeleteGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaInstanceRequest"/></param>
        /// <returns><see cref="DeleteGrafanaInstanceResponse"/></returns>
        public DeleteGrafanaInstanceResponse DeleteGrafanaInstanceSync(DeleteGrafanaInstanceRequest req)
        {
             JsonResponseModel<DeleteGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="DeleteGrafanaIntegrationResponse"/></returns>
        public async Task<DeleteGrafanaIntegrationResponse> DeleteGrafanaIntegration(DeleteGrafanaIntegrationRequest req)
        {
             JsonResponseModel<DeleteGrafanaIntegrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGrafanaIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGrafanaIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="DeleteGrafanaIntegrationResponse"/></returns>
        public DeleteGrafanaIntegrationResponse DeleteGrafanaIntegrationSync(DeleteGrafanaIntegrationRequest req)
        {
             JsonResponseModel<DeleteGrafanaIntegrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGrafanaIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGrafanaIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="DeleteGrafanaNotificationChannelResponse"/></returns>
        public async Task<DeleteGrafanaNotificationChannelResponse> DeleteGrafanaNotificationChannel(DeleteGrafanaNotificationChannelRequest req)
        {
             JsonResponseModel<DeleteGrafanaNotificationChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGrafanaNotificationChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGrafanaNotificationChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="DeleteGrafanaNotificationChannelResponse"/></returns>
        public DeleteGrafanaNotificationChannelResponse DeleteGrafanaNotificationChannelSync(DeleteGrafanaNotificationChannelRequest req)
        {
             JsonResponseModel<DeleteGrafanaNotificationChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGrafanaNotificationChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGrafanaNotificationChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alarm policy group.
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public async Task<DeletePolicyGroupResponse> DeletePolicyGroup(DeletePolicyGroupRequest req)
        {
             JsonResponseModel<DeletePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an alarm policy group.
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public DeletePolicyGroupResponse DeletePolicyGroupSync(DeletePolicyGroupRequest req)
        {
             JsonResponseModel<DeletePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a TMP 2.0 instance alerting rule.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertPolicyResponse"/></returns>
        public async Task<DeletePrometheusAlertPolicyResponse> DeletePrometheusAlertPolicy(DeletePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<DeletePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a TMP 2.0 instance alerting rule.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertPolicyResponse"/></returns>
        public DeletePrometheusAlertPolicyResponse DeletePrometheusAlertPolicySync(DeletePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<DeletePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disassociate a TMP instance from a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="DeletePrometheusClusterAgentResponse"/></returns>
        public async Task<DeletePrometheusClusterAgentResponse> DeletePrometheusClusterAgent(DeletePrometheusClusterAgentRequest req)
        {
             JsonResponseModel<DeletePrometheusClusterAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusClusterAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusClusterAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disassociate a TMP instance from a cluster.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="DeletePrometheusClusterAgentResponse"/></returns>
        public DeletePrometheusClusterAgentResponse DeletePrometheusClusterAgentSync(DeletePrometheusClusterAgentRequest req)
        {
             JsonResponseModel<DeletePrometheusClusterAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusClusterAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusClusterAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Prometheus configurations. If the target cluster does not exist, a result indicating success will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusConfigRequest"/></param>
        /// <returns><see cref="DeletePrometheusConfigResponse"/></returns>
        public async Task<DeletePrometheusConfigResponse> DeletePrometheusConfig(DeletePrometheusConfigRequest req)
        {
             JsonResponseModel<DeletePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete Prometheus configurations. If the target cluster does not exist, a result indicating success will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusConfigRequest"/></param>
        /// <returns><see cref="DeletePrometheusConfigResponse"/></returns>
        public DeletePrometheusConfigResponse DeletePrometheusConfigSync(DeletePrometheusConfigRequest req)
        {
             JsonResponseModel<DeletePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a recording instance.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DeletePrometheusRecordRuleYamlResponse"/></returns>
        public async Task<DeletePrometheusRecordRuleYamlResponse> DeletePrometheusRecordRuleYaml(DeletePrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<DeletePrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a recording instance.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DeletePrometheusRecordRuleYamlResponse"/></returns>
        public DeletePrometheusRecordRuleYamlResponse DeletePrometheusRecordRuleYamlSync(DeletePrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<DeletePrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DeletePrometheusScrapeJobsResponse"/></returns>
        public async Task<DeletePrometheusScrapeJobsResponse> DeletePrometheusScrapeJobs(DeletePrometheusScrapeJobsRequest req)
        {
             JsonResponseModel<DeletePrometheusScrapeJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusScrapeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusScrapeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DeletePrometheusScrapeJobsResponse"/></returns>
        public DeletePrometheusScrapeJobsResponse DeletePrometheusScrapeJobsSync(DeletePrometheusScrapeJobsRequest req)
        {
             JsonResponseModel<DeletePrometheusScrapeJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusScrapeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusScrapeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a TMP template.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempResponse"/></returns>
        public async Task<DeletePrometheusTempResponse> DeletePrometheusTemp(DeletePrometheusTempRequest req)
        {
             JsonResponseModel<DeletePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a TMP template.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempResponse"/></returns>
        public DeletePrometheusTempResponse DeletePrometheusTempSync(DeletePrometheusTempRequest req)
        {
             JsonResponseModel<DeletePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unsync a template, which will delete the configuration generated by the template in the target. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempSyncResponse"/></returns>
        public async Task<DeletePrometheusTempSyncResponse> DeletePrometheusTempSync(DeletePrometheusTempSyncRequest req)
        {
             JsonResponseModel<DeletePrometheusTempSyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrometheusTempSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTempSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unsync a template, which will delete the configuration generated by the template in the target. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempSyncResponse"/></returns>
        public DeletePrometheusTempSyncResponse DeletePrometheusTempSyncSync(DeletePrometheusTempSyncRequest req)
        {
             JsonResponseModel<DeletePrometheusTempSyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrometheusTempSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrometheusTempSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete Prometheus recording rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingRulesRequest"/></param>
        /// <returns><see cref="DeleteRecordingRulesResponse"/></returns>
        public async Task<DeleteRecordingRulesResponse> DeleteRecordingRules(DeleteRecordingRulesRequest req)
        {
             JsonResponseModel<DeleteRecordingRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecordingRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordingRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete Prometheus recording rules.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingRulesRequest"/></param>
        /// <returns><see cref="DeleteRecordingRulesResponse"/></returns>
        public DeleteRecordingRulesResponse DeleteRecordingRulesSync(DeleteRecordingRulesRequest req)
        {
             JsonResponseModel<DeleteRecordingRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecordingRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordingRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an authorized TCMG user.
        /// </summary>
        /// <param name="req"><see cref="DeleteSSOAccountRequest"/></param>
        /// <returns><see cref="DeleteSSOAccountResponse"/></returns>
        public async Task<DeleteSSOAccountResponse> DeleteSSOAccount(DeleteSSOAccountRequest req)
        {
             JsonResponseModel<DeleteSSOAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSSOAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSSOAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an authorized TCMG user.
        /// </summary>
        /// <param name="req"><see cref="DeleteSSOAccountRequest"/></param>
        /// <returns><see cref="DeleteSSOAccountResponse"/></returns>
        public DeleteSSOAccountResponse DeleteSSOAccountSync(DeleteSSOAccountRequest req)
        {
             JsonResponseModel<DeleteSSOAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSSOAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSSOAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the platform event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public async Task<DescribeAccidentEventListResponse> DescribeAccidentEventList(DescribeAccidentEventListRequest req)
        {
             JsonResponseModel<DescribeAccidentEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccidentEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccidentEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the platform event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public DescribeAccidentEventListResponse DescribeAccidentEventListSync(DescribeAccidentEventListRequest req)
        {
             JsonResponseModel<DescribeAccidentEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccidentEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccidentEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of alarm events.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public async Task<DescribeAlarmEventsResponse> DescribeAlarmEvents(DescribeAlarmEventsRequest req)
        {
             JsonResponseModel<DescribeAlarmEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of alarm events.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public DescribeAlarmEventsResponse DescribeAlarmEventsSync(DescribeAlarmEventsRequest req)
        {
             JsonResponseModel<DescribeAlarmEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the alarm records.
        /// 
        /// Note: **If you use a sub-account, you can only query the alarm records of authorized projects** or uncategorized products.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmHistoriesResponse"/></returns>
        public async Task<DescribeAlarmHistoriesResponse> DescribeAlarmHistories(DescribeAlarmHistoriesRequest req)
        {
             JsonResponseModel<DescribeAlarmHistoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmHistories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmHistoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeAlarmHistoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmHistories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmHistoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of alarm metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmMetricsRequest"/></param>
        /// <returns><see cref="DescribeAlarmMetricsResponse"/></returns>
        public async Task<DescribeAlarmMetricsResponse> DescribeAlarmMetrics(DescribeAlarmMetricsRequest req)
        {
             JsonResponseModel<DescribeAlarmMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of alarm metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmMetricsRequest"/></param>
        /// <returns><see cref="DescribeAlarmMetricsResponse"/></returns>
        public DescribeAlarmMetricsResponse DescribeAlarmMetricsSync(DescribeAlarmMetricsRequest req)
        {
             JsonResponseModel<DescribeAlarmMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a single notification template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeResponse"/></returns>
        public async Task<DescribeAlarmNoticeResponse> DescribeAlarmNotice(DescribeAlarmNoticeRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a single notification template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeResponse"/></returns>
        public DescribeAlarmNoticeResponse DescribeAlarmNoticeSync(DescribeAlarmNoticeRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get all the callback URLs of an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeCallbacksRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeCallbacksResponse"/></returns>
        public async Task<DescribeAlarmNoticeCallbacksResponse> DescribeAlarmNoticeCallbacks(DescribeAlarmNoticeCallbacksRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticeCallbacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmNoticeCallbacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticeCallbacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get all the callback URLs of an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeCallbacksRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeCallbacksResponse"/></returns>
        public DescribeAlarmNoticeCallbacksResponse DescribeAlarmNoticeCallbacksSync(DescribeAlarmNoticeCallbacksRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticeCallbacksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmNoticeCallbacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticeCallbacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of notification templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public async Task<DescribeAlarmNoticesResponse> DescribeAlarmNotices(DescribeAlarmNoticesRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmNotices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of notification templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public DescribeAlarmNoticesResponse DescribeAlarmNoticesSync(DescribeAlarmNoticesRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmNotices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of alarm policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAlarmPoliciesResponse"/></returns>
        public async Task<DescribeAlarmPoliciesResponse> DescribeAlarmPolicies(DescribeAlarmPoliciesRequest req)
        {
             JsonResponseModel<DescribeAlarmPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of alarm policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAlarmPoliciesResponse"/></returns>
        public DescribeAlarmPoliciesResponse DescribeAlarmPoliciesSync(DescribeAlarmPoliciesRequest req)
        {
             JsonResponseModel<DescribeAlarmPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a single alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPolicyRequest"/></param>
        /// <returns><see cref="DescribeAlarmPolicyResponse"/></returns>
        public async Task<DescribeAlarmPolicyResponse> DescribeAlarmPolicy(DescribeAlarmPolicyRequest req)
        {
             JsonResponseModel<DescribeAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a single alarm policy.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPolicyRequest"/></param>
        /// <returns><see cref="DescribeAlarmPolicyResponse"/></returns>
        public DescribeAlarmPolicyResponse DescribeAlarmPolicySync(DescribeAlarmPolicyRequest req)
        {
             JsonResponseModel<DescribeAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a Prometheus alerting rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRulesRequest"/></param>
        /// <returns><see cref="DescribeAlertRulesResponse"/></returns>
        public async Task<DescribeAlertRulesResponse> DescribeAlertRules(DescribeAlertRulesRequest req)
        {
             JsonResponseModel<DescribeAlertRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlertRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlertRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a Prometheus alerting rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRulesRequest"/></param>
        /// <returns><see cref="DescribeAlertRulesResponse"/></returns>
        public DescribeAlertRulesResponse DescribeAlertRulesSync(DescribeAlertRulesRequest req)
        {
             JsonResponseModel<DescribeAlertRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlertRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlertRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all namespaces.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeAllNamespacesResponse"/></returns>
        public async Task<DescribeAllNamespacesResponse> DescribeAllNamespaces(DescribeAllNamespacesRequest req)
        {
             JsonResponseModel<DescribeAllNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all namespaces.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeAllNamespacesResponse"/></returns>
        public DescribeAllNamespacesResponse DescribeAllNamespacesSync(DescribeAllNamespacesRequest req)
        {
             JsonResponseModel<DescribeAllNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the attributes of basic metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public async Task<DescribeBaseMetricsResponse> DescribeBaseMetrics(DescribeBaseMetricsRequest req)
        {
             JsonResponseModel<DescribeBaseMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaseMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the attributes of basic metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public DescribeBaseMetricsResponse DescribeBaseMetricsSync(DescribeBaseMetricsRequest req)
        {
             JsonResponseModel<DescribeBaseMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaseMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the basic alarm list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public async Task<DescribeBasicAlarmListResponse> DescribeBasicAlarmList(DescribeBasicAlarmListRequest req)
        {
             JsonResponseModel<DescribeBasicAlarmListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicAlarmList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicAlarmListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the basic alarm list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public DescribeBasicAlarmListResponse DescribeBasicAlarmListSync(DescribeBasicAlarmListRequest req)
        {
             JsonResponseModel<DescribeBasicAlarmListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicAlarmList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicAlarmListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the bound object list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public async Task<DescribeBindingPolicyObjectListResponse> DescribeBindingPolicyObjectList(DescribeBindingPolicyObjectListRequest req)
        {
             JsonResponseModel<DescribeBindingPolicyObjectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindingPolicyObjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindingPolicyObjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the bound object list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public DescribeBindingPolicyObjectListResponse DescribeBindingPolicyObjectListSync(DescribeBindingPolicyObjectListRequest req)
        {
             JsonResponseModel<DescribeBindingPolicyObjectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindingPolicyObjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindingPolicyObjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the trigger condition template.
        /// </summary>
        /// <param name="req"><see cref="DescribeConditionsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeConditionsTemplateListResponse"/></returns>
        public async Task<DescribeConditionsTemplateListResponse> DescribeConditionsTemplateList(DescribeConditionsTemplateListRequest req)
        {
             JsonResponseModel<DescribeConditionsTemplateListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConditionsTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConditionsTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the trigger condition template.
        /// </summary>
        /// <param name="req"><see cref="DescribeConditionsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeConditionsTemplateListResponse"/></returns>
        public DescribeConditionsTemplateListResponse DescribeConditionsTemplateListSync(DescribeConditionsTemplateListRequest req)
        {
             JsonResponseModel<DescribeConditionsTemplateListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConditionsTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConditionsTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Grafana DNS configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeDNSConfigRequest"/></param>
        /// <returns><see cref="DescribeDNSConfigResponse"/></returns>
        public async Task<DescribeDNSConfigResponse> DescribeDNSConfig(DescribeDNSConfigRequest req)
        {
             JsonResponseModel<DescribeDNSConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDNSConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDNSConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Grafana DNS configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeDNSConfigRequest"/></param>
        /// <returns><see cref="DescribeDNSConfigResponse"/></returns>
        public DescribeDNSConfigResponse DescribeDNSConfigSync(DescribeDNSConfigRequest req)
        {
             JsonResponseModel<DescribeDNSConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDNSConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDNSConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of exporter integrations.
        /// </summary>
        /// <param name="req"><see cref="DescribeExporterIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeExporterIntegrationsResponse"/></returns>
        public async Task<DescribeExporterIntegrationsResponse> DescribeExporterIntegrations(DescribeExporterIntegrationsRequest req)
        {
             JsonResponseModel<DescribeExporterIntegrationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExporterIntegrations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExporterIntegrationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of exporter integrations.
        /// </summary>
        /// <param name="req"><see cref="DescribeExporterIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeExporterIntegrationsResponse"/></returns>
        public DescribeExporterIntegrationsResponse DescribeExporterIntegrationsSync(DescribeExporterIntegrationsRequest req)
        {
             JsonResponseModel<DescribeExporterIntegrationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExporterIntegrations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExporterIntegrationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list all Grafana alert channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaChannelsResponse"/></returns>
        public async Task<DescribeGrafanaChannelsResponse> DescribeGrafanaChannels(DescribeGrafanaChannelsRequest req)
        {
             JsonResponseModel<DescribeGrafanaChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGrafanaChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list all Grafana alert channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaChannelsResponse"/></returns>
        public DescribeGrafanaChannelsResponse DescribeGrafanaChannelsSync(DescribeGrafanaChannelsRequest req)
        {
             JsonResponseModel<DescribeGrafanaChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGrafanaChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Grafana settings, i.e., the `grafana.ini` file content.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaConfigRequest"/></param>
        /// <returns><see cref="DescribeGrafanaConfigResponse"/></returns>
        public async Task<DescribeGrafanaConfigResponse> DescribeGrafanaConfig(DescribeGrafanaConfigRequest req)
        {
             JsonResponseModel<DescribeGrafanaConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGrafanaConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Grafana settings, i.e., the `grafana.ini` file content.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaConfigRequest"/></param>
        /// <returns><see cref="DescribeGrafanaConfigResponse"/></returns>
        public DescribeGrafanaConfigResponse DescribeGrafanaConfigSync(DescribeGrafanaConfigRequest req)
        {
             JsonResponseModel<DescribeGrafanaConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGrafanaConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Grafana environment variables.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaEnvironmentsResponse"/></returns>
        public async Task<DescribeGrafanaEnvironmentsResponse> DescribeGrafanaEnvironments(DescribeGrafanaEnvironmentsRequest req)
        {
             JsonResponseModel<DescribeGrafanaEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGrafanaEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Grafana environment variables.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaEnvironmentsResponse"/></returns>
        public DescribeGrafanaEnvironmentsResponse DescribeGrafanaEnvironmentsSync(DescribeGrafanaEnvironmentsRequest req)
        {
             JsonResponseModel<DescribeGrafanaEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGrafanaEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list all Grafana instances under a user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaInstancesRequest"/></param>
        /// <returns><see cref="DescribeGrafanaInstancesResponse"/></returns>
        public async Task<DescribeGrafanaInstancesResponse> DescribeGrafanaInstances(DescribeGrafanaInstancesRequest req)
        {
             JsonResponseModel<DescribeGrafanaInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGrafanaInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list all Grafana instances under a user account.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaInstancesRequest"/></param>
        /// <returns><see cref="DescribeGrafanaInstancesResponse"/></returns>
        public DescribeGrafanaInstancesResponse DescribeGrafanaInstancesSync(DescribeGrafanaInstancesRequest req)
        {
             JsonResponseModel<DescribeGrafanaInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGrafanaInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list installed Grafana integrations.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaIntegrationsResponse"/></returns>
        public async Task<DescribeGrafanaIntegrationsResponse> DescribeGrafanaIntegrations(DescribeGrafanaIntegrationsRequest req)
        {
             JsonResponseModel<DescribeGrafanaIntegrationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGrafanaIntegrations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaIntegrationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list installed Grafana integrations.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaIntegrationsResponse"/></returns>
        public DescribeGrafanaIntegrationsResponse DescribeGrafanaIntegrationsSync(DescribeGrafanaIntegrationsRequest req)
        {
             JsonResponseModel<DescribeGrafanaIntegrationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGrafanaIntegrations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaIntegrationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Grafana notification channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaNotificationChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaNotificationChannelsResponse"/></returns>
        public async Task<DescribeGrafanaNotificationChannelsResponse> DescribeGrafanaNotificationChannels(DescribeGrafanaNotificationChannelsRequest req)
        {
             JsonResponseModel<DescribeGrafanaNotificationChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGrafanaNotificationChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaNotificationChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Grafana notification channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaNotificationChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaNotificationChannelsResponse"/></returns>
        public DescribeGrafanaNotificationChannelsResponse DescribeGrafanaNotificationChannelsSync(DescribeGrafanaNotificationChannelsRequest req)
        {
             JsonResponseModel<DescribeGrafanaNotificationChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGrafanaNotificationChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaNotificationChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the Grafana allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="DescribeGrafanaWhiteListResponse"/></returns>
        public async Task<DescribeGrafanaWhiteListResponse> DescribeGrafanaWhiteList(DescribeGrafanaWhiteListRequest req)
        {
             JsonResponseModel<DescribeGrafanaWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGrafanaWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the Grafana allowlist.
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="DescribeGrafanaWhiteListResponse"/></returns>
        public DescribeGrafanaWhiteListResponse DescribeGrafanaWhiteListSync(DescribeGrafanaWhiteListRequest req)
        {
             JsonResponseModel<DescribeGrafanaWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGrafanaWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGrafanaWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the plugins installed in an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstalledPluginsRequest"/></param>
        /// <returns><see cref="DescribeInstalledPluginsResponse"/></returns>
        public async Task<DescribeInstalledPluginsResponse> DescribeInstalledPlugins(DescribeInstalledPluginsRequest req)
        {
             JsonResponseModel<DescribeInstalledPluginsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstalledPlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstalledPluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the plugins installed in an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstalledPluginsRequest"/></param>
        /// <returns><see cref="DescribeInstalledPluginsResponse"/></returns>
        public DescribeInstalledPluginsResponse DescribeInstalledPluginsSync(DescribeInstalledPluginsRequest req)
        {
             JsonResponseModel<DescribeInstalledPluginsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstalledPlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstalledPluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list all the monitor types supported by CM.
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorTypesRequest"/></param>
        /// <returns><see cref="DescribeMonitorTypesResponse"/></returns>
        public async Task<DescribeMonitorTypesResponse> DescribeMonitorTypes(DescribeMonitorTypesRequest req)
        {
             JsonResponseModel<DescribeMonitorTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMonitorTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list all the monitor types supported by CM.
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorTypesRequest"/></param>
        /// <returns><see cref="DescribeMonitorTypesResponse"/></returns>
        public DescribeMonitorTypesResponse DescribeMonitorTypesSync(DescribeMonitorTypesRequest req)
        {
             JsonResponseModel<DescribeMonitorTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMonitorTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get basic alarm policy conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public async Task<DescribePolicyConditionListResponse> DescribePolicyConditionList(DescribePolicyConditionListRequest req)
        {
             JsonResponseModel<DescribePolicyConditionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyConditionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyConditionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get basic alarm policy conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public DescribePolicyConditionListResponse DescribePolicyConditionListSync(DescribePolicyConditionListRequest req)
        {
             JsonResponseModel<DescribePolicyConditionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyConditionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyConditionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get details of a basic policy group.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public async Task<DescribePolicyGroupInfoResponse> DescribePolicyGroupInfo(DescribePolicyGroupInfoRequest req)
        {
             JsonResponseModel<DescribePolicyGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get details of a basic policy group.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public DescribePolicyGroupInfoResponse DescribePolicyGroupInfoSync(DescribePolicyGroupInfoRequest req)
        {
             JsonResponseModel<DescribePolicyGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of basic policy alarm groups.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public async Task<DescribePolicyGroupListResponse> DescribePolicyGroupList(DescribePolicyGroupListRequest req)
        {
             JsonResponseModel<DescribePolicyGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of basic policy alarm groups.
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public DescribePolicyGroupListResponse DescribePolicyGroupListSync(DescribePolicyGroupListRequest req)
        {
             JsonResponseModel<DescribePolicyGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of product events by page.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public async Task<DescribeProductEventListResponse> DescribeProductEventList(DescribeProductEventListRequest req)
        {
             JsonResponseModel<DescribeProductEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of product events by page.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public DescribeProductEventListResponse DescribeProductEventListSync(DescribeProductEventListRequest req)
        {
             JsonResponseModel<DescribeProductEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of instances associated with the target cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentInstancesResponse"/></returns>
        public async Task<DescribePrometheusAgentInstancesResponse> DescribePrometheusAgentInstances(DescribePrometheusAgentInstancesRequest req)
        {
             JsonResponseModel<DescribePrometheusAgentInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusAgentInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAgentInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of instances associated with the target cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentInstancesResponse"/></returns>
        public DescribePrometheusAgentInstancesResponse DescribePrometheusAgentInstancesSync(DescribePrometheusAgentInstancesRequest req)
        {
             JsonResponseModel<DescribePrometheusAgentInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusAgentInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAgentInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Prometheus CVM agents.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentsResponse"/></returns>
        public async Task<DescribePrometheusAgentsResponse> DescribePrometheusAgents(DescribePrometheusAgentsRequest req)
        {
             JsonResponseModel<DescribePrometheusAgentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusAgents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAgentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Prometheus CVM agents.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentsResponse"/></returns>
        public DescribePrometheusAgentsResponse DescribePrometheusAgentsSync(DescribePrometheusAgentsRequest req)
        {
             JsonResponseModel<DescribePrometheusAgentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusAgents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAgentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of v2.0 instance alerting rules.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertPolicyResponse"/></returns>
        public async Task<DescribePrometheusAlertPolicyResponse> DescribePrometheusAlertPolicy(DescribePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<DescribePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of v2.0 instance alerting rules.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertPolicyResponse"/></returns>
        public DescribePrometheusAlertPolicyResponse DescribePrometheusAlertPolicySync(DescribePrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<DescribePrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of clusters associated with the TMP instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusClusterAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusClusterAgentsResponse"/></returns>
        public async Task<DescribePrometheusClusterAgentsResponse> DescribePrometheusClusterAgents(DescribePrometheusClusterAgentsRequest req)
        {
             JsonResponseModel<DescribePrometheusClusterAgentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusClusterAgents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusClusterAgentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of clusters associated with the TMP instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusClusterAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusClusterAgentsResponse"/></returns>
        public DescribePrometheusClusterAgentsResponse DescribePrometheusClusterAgentsSync(DescribePrometheusClusterAgentsRequest req)
        {
             JsonResponseModel<DescribePrometheusClusterAgentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusClusterAgents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusClusterAgentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the Prometheus configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusConfigResponse"/></returns>
        public async Task<DescribePrometheusConfigResponse> DescribePrometheusConfig(DescribePrometheusConfigRequest req)
        {
             JsonResponseModel<DescribePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the Prometheus configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusConfigResponse"/></returns>
        public DescribePrometheusConfigResponse DescribePrometheusConfigSync(DescribePrometheusConfigRequest req)
        {
             JsonResponseModel<DescribePrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the instance-level scrape configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalConfigResponse"/></returns>
        public async Task<DescribePrometheusGlobalConfigResponse> DescribePrometheusGlobalConfig(DescribePrometheusGlobalConfigRequest req)
        {
             JsonResponseModel<DescribePrometheusGlobalConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusGlobalConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusGlobalConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the instance-level scrape configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalConfigResponse"/></returns>
        public DescribePrometheusGlobalConfigResponse DescribePrometheusGlobalConfigSync(DescribePrometheusGlobalConfigRequest req)
        {
             JsonResponseModel<DescribePrometheusGlobalConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusGlobalConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusGlobalConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalNotificationResponse"/></returns>
        public async Task<DescribePrometheusGlobalNotificationResponse> DescribePrometheusGlobalNotification(DescribePrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<DescribePrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalNotificationResponse"/></returns>
        public DescribePrometheusGlobalNotificationResponse DescribePrometheusGlobalNotificationSync(DescribePrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<DescribePrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a TMP instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceDetailResponse"/></returns>
        public async Task<DescribePrometheusInstanceDetailResponse> DescribePrometheusInstanceDetail(DescribePrometheusInstanceDetailRequest req)
        {
             JsonResponseModel<DescribePrometheusInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a TMP instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceDetailResponse"/></returns>
        public DescribePrometheusInstanceDetailResponse DescribePrometheusInstanceDetailSync(DescribePrometheusInstanceDetailRequest req)
        {
             JsonResponseModel<DescribePrometheusInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the initialization task status of a v2.0 instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceInitStatusRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceInitStatusResponse"/></returns>
        public async Task<DescribePrometheusInstanceInitStatusResponse> DescribePrometheusInstanceInitStatus(DescribePrometheusInstanceInitStatusRequest req)
        {
             JsonResponseModel<DescribePrometheusInstanceInitStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusInstanceInitStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstanceInitStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the initialization task status of a v2.0 instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceInitStatusRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceInitStatusResponse"/></returns>
        public DescribePrometheusInstanceInitStatusResponse DescribePrometheusInstanceInitStatusSync(DescribePrometheusInstanceInitStatusRequest req)
        {
             JsonResponseModel<DescribePrometheusInstanceInitStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusInstanceInitStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstanceInitStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to query the usage of a pay-as-you-go Tencent Managed Service for Prometheus (TMP) instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceUsageRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceUsageResponse"/></returns>
        public async Task<DescribePrometheusInstanceUsageResponse> DescribePrometheusInstanceUsage(DescribePrometheusInstanceUsageRequest req)
        {
             JsonResponseModel<DescribePrometheusInstanceUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusInstanceUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstanceUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to query the usage of a pay-as-you-go Tencent Managed Service for Prometheus (TMP) instance.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceUsageRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceUsageResponse"/></returns>
        public DescribePrometheusInstanceUsageResponse DescribePrometheusInstanceUsageSync(DescribePrometheusInstanceUsageRequest req)
        {
             JsonResponseModel<DescribePrometheusInstanceUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusInstanceUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstanceUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<DescribePrometheusInstancesResponse> DescribePrometheusInstances(DescribePrometheusInstancesRequest req)
        {
             JsonResponseModel<DescribePrometheusInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribePrometheusInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of CM-integrated instances.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesOverviewRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesOverviewResponse"/></returns>
        public async Task<DescribePrometheusInstancesOverviewResponse> DescribePrometheusInstancesOverview(DescribePrometheusInstancesOverviewRequest req)
        {
             JsonResponseModel<DescribePrometheusInstancesOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusInstancesOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstancesOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of CM-integrated instances.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesOverviewRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesOverviewResponse"/></returns>
        public DescribePrometheusInstancesOverviewResponse DescribePrometheusInstancesOverviewSync(DescribePrometheusInstancesOverviewRequest req)
        {
             JsonResponseModel<DescribePrometheusInstancesOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusInstancesOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusInstancesOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the YAML list of Prometheus recording rules.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRuleYamlResponse"/></returns>
        public async Task<DescribePrometheusRecordRuleYamlResponse> DescribePrometheusRecordRuleYaml(DescribePrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<DescribePrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the YAML list of Prometheus recording rules.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRuleYamlResponse"/></returns>
        public DescribePrometheusRecordRuleYamlResponse DescribePrometheusRecordRuleYamlSync(DescribePrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<DescribePrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of recording rules, including those created by CRD resources in the associated cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRulesRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRulesResponse"/></returns>
        public async Task<DescribePrometheusRecordRulesResponse> DescribePrometheusRecordRules(DescribePrometheusRecordRulesRequest req)
        {
             JsonResponseModel<DescribePrometheusRecordRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusRecordRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusRecordRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of recording rules, including those created by CRD resources in the associated cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRulesRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRulesResponse"/></returns>
        public DescribePrometheusRecordRulesResponse DescribePrometheusRecordRulesSync(DescribePrometheusRecordRulesRequest req)
        {
             JsonResponseModel<DescribePrometheusRecordRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusRecordRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusRecordRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Prometheus scrape tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DescribePrometheusScrapeJobsResponse"/></returns>
        public async Task<DescribePrometheusScrapeJobsResponse> DescribePrometheusScrapeJobs(DescribePrometheusScrapeJobsRequest req)
        {
             JsonResponseModel<DescribePrometheusScrapeJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusScrapeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusScrapeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Prometheus scrape tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DescribePrometheusScrapeJobsResponse"/></returns>
        public DescribePrometheusScrapeJobsResponse DescribePrometheusScrapeJobsSync(DescribePrometheusScrapeJobsRequest req)
        {
             JsonResponseModel<DescribePrometheusScrapeJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusScrapeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusScrapeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the targets information.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTargetsTMPRequest"/></param>
        /// <returns><see cref="DescribePrometheusTargetsTMPResponse"/></returns>
        public async Task<DescribePrometheusTargetsTMPResponse> DescribePrometheusTargetsTMP(DescribePrometheusTargetsTMPRequest req)
        {
             JsonResponseModel<DescribePrometheusTargetsTMPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusTargetsTMP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTargetsTMPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the targets information.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTargetsTMPRequest"/></param>
        /// <returns><see cref="DescribePrometheusTargetsTMPResponse"/></returns>
        public DescribePrometheusTargetsTMPResponse DescribePrometheusTargetsTMPSync(DescribePrometheusTargetsTMPRequest req)
        {
             JsonResponseModel<DescribePrometheusTargetsTMPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusTargetsTMP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTargetsTMPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of templates, where the default template is always on top.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempResponse"/></returns>
        public async Task<DescribePrometheusTempResponse> DescribePrometheusTemp(DescribePrometheusTempRequest req)
        {
             JsonResponseModel<DescribePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of templates, where the default template is always on top.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempResponse"/></returns>
        public DescribePrometheusTempResponse DescribePrometheusTempSync(DescribePrometheusTempRequest req)
        {
             JsonResponseModel<DescribePrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of instances associated with a template. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempSyncResponse"/></returns>
        public async Task<DescribePrometheusTempSyncResponse> DescribePrometheusTempSync(DescribePrometheusTempSyncRequest req)
        {
             JsonResponseModel<DescribePrometheusTempSyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusTempSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTempSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of instances associated with a template. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempSyncResponse"/></returns>
        public DescribePrometheusTempSyncResponse DescribePrometheusTempSyncSync(DescribePrometheusTempSyncRequest req)
        {
             JsonResponseModel<DescribePrometheusTempSyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusTempSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusTempSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the AZs of Tencent Managed Service for Prometheus (TMP).
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusZonesRequest"/></param>
        /// <returns><see cref="DescribePrometheusZonesResponse"/></returns>
        public async Task<DescribePrometheusZonesResponse> DescribePrometheusZones(DescribePrometheusZonesRequest req)
        {
             JsonResponseModel<DescribePrometheusZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrometheusZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the AZs of Tencent Managed Service for Prometheus (TMP).
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusZonesRequest"/></param>
        /// <returns><see cref="DescribePrometheusZonesResponse"/></returns>
        public DescribePrometheusZonesResponse DescribePrometheusZonesSync(DescribePrometheusZonesRequest req)
        {
             JsonResponseModel<DescribePrometheusZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrometheusZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrometheusZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query Prometheus recording rules by filter.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingRulesRequest"/></param>
        /// <returns><see cref="DescribeRecordingRulesResponse"/></returns>
        public async Task<DescribeRecordingRulesResponse> DescribeRecordingRules(DescribeRecordingRulesRequest req)
        {
             JsonResponseModel<DescribeRecordingRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecordingRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordingRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query Prometheus recording rules by filter.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingRulesRequest"/></param>
        /// <returns><see cref="DescribeRecordingRulesResponse"/></returns>
        public DescribeRecordingRulesResponse DescribeRecordingRulesSync(DescribeRecordingRulesRequest req)
        {
             JsonResponseModel<DescribeRecordingRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecordingRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordingRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list all authorized accounts of the current Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSSOAccountRequest"/></param>
        /// <returns><see cref="DescribeSSOAccountResponse"/></returns>
        public async Task<DescribeSSOAccountResponse> DescribeSSOAccount(DescribeSSOAccountRequest req)
        {
             JsonResponseModel<DescribeSSOAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSSOAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSSOAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list all authorized accounts of the current Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSSOAccountRequest"/></param>
        /// <returns><see cref="DescribeSSOAccountResponse"/></returns>
        public DescribeSSOAccountResponse DescribeSSOAccountSync(DescribeSSOAccountRequest req)
        {
             JsonResponseModel<DescribeSSOAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSSOAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSSOAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list Prometheus scrape configurations in TKE.
        /// <p>Note: The prerequisite is that the corresponding TKE service has been integrated through the Prometheus console. For more information, see
        /// <a href="https://intl.cloud.tencent.com/document/product/248/48859?from_cn_redirect=1" target="_blank">Agent Management</a>.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceDiscoveryRequest"/></param>
        /// <returns><see cref="DescribeServiceDiscoveryResponse"/></returns>
        public async Task<DescribeServiceDiscoveryResponse> DescribeServiceDiscovery(DescribeServiceDiscoveryRequest req)
        {
             JsonResponseModel<DescribeServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query monitoring data by dimension conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDataRequest"/></param>
        /// <returns><see cref="DescribeStatisticDataResponse"/></returns>
        public async Task<DescribeStatisticDataResponse> DescribeStatisticData(DescribeStatisticDataRequest req)
        {
             JsonResponseModel<DescribeStatisticDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStatisticData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStatisticDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query monitoring data by dimension conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDataRequest"/></param>
        /// <returns><see cref="DescribeStatisticDataResponse"/></returns>
        public DescribeStatisticDataResponse DescribeStatisticDataSync(DescribeStatisticDataRequest req)
        {
             JsonResponseModel<DescribeStatisticDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStatisticData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStatisticDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the data of a Prometheus instance. The specified instance must be terminated first.
        /// </summary>
        /// <param name="req"><see cref="DestroyPrometheusInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrometheusInstanceResponse"/></returns>
        public async Task<DestroyPrometheusInstanceResponse> DestroyPrometheusInstance(DestroyPrometheusInstanceRequest req)
        {
             JsonResponseModel<DestroyPrometheusInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyPrometheusInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPrometheusInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the data of a Prometheus instance. The specified instance must be terminated first.
        /// </summary>
        /// <param name="req"><see cref="DestroyPrometheusInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrometheusInstanceResponse"/></returns>
        public DestroyPrometheusInstanceResponse DestroyPrometheusInstanceSync(DestroyPrometheusInstanceRequest req)
        {
             JsonResponseModel<DestroyPrometheusInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyPrometheusInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPrometheusInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the Grafana public network access.
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaInternetRequest"/></param>
        /// <returns><see cref="EnableGrafanaInternetResponse"/></returns>
        public async Task<EnableGrafanaInternetResponse> EnableGrafanaInternet(EnableGrafanaInternetRequest req)
        {
             JsonResponseModel<EnableGrafanaInternetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableGrafanaInternet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableGrafanaInternetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the Grafana public network access.
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaInternetRequest"/></param>
        /// <returns><see cref="EnableGrafanaInternetResponse"/></returns>
        public EnableGrafanaInternetResponse EnableGrafanaInternetSync(EnableGrafanaInternetRequest req)
        {
             JsonResponseModel<EnableGrafanaInternetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableGrafanaInternet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableGrafanaInternetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the Grafana SSO through a Tencent Cloud account.
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaSSORequest"/></param>
        /// <returns><see cref="EnableGrafanaSSOResponse"/></returns>
        public async Task<EnableGrafanaSSOResponse> EnableGrafanaSSO(EnableGrafanaSSORequest req)
        {
             JsonResponseModel<EnableGrafanaSSOResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableGrafanaSSO");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableGrafanaSSOResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the Grafana SSO through a Tencent Cloud account.
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaSSORequest"/></param>
        /// <returns><see cref="EnableGrafanaSSOResponse"/></returns>
        public EnableGrafanaSSOResponse EnableGrafanaSSOSync(EnableGrafanaSSORequest req)
        {
             JsonResponseModel<EnableGrafanaSSOResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableGrafanaSSO");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableGrafanaSSOResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set whether to enable CAM authentication during SSO.
        /// </summary>
        /// <param name="req"><see cref="EnableSSOCamCheckRequest"/></param>
        /// <returns><see cref="EnableSSOCamCheckResponse"/></returns>
        public async Task<EnableSSOCamCheckResponse> EnableSSOCamCheck(EnableSSOCamCheckRequest req)
        {
             JsonResponseModel<EnableSSOCamCheckResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableSSOCamCheck");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableSSOCamCheckResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set whether to enable CAM authentication during SSO.
        /// </summary>
        /// <param name="req"><see cref="EnableSSOCamCheckRequest"/></param>
        /// <returns><see cref="EnableSSOCamCheckResponse"/></returns>
        public EnableSSOCamCheckResponse EnableSSOCamCheckSync(EnableSSOCamCheckRequest req)
        {
             JsonResponseModel<EnableSSOCamCheckResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableSSOCamCheck");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableSSOCamCheckResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the monitoring data of Tencent Cloud services except TKE. To pull TKE’s monitoring data, use the [DescribeStatisticData](https://www.tencentcloud.com/document/product/248/39481) API.
        /// You can get the monitoring data of a Tencent Cloud service by passing in its namespace, object dimension description, and monitoring metrics.
        /// API call rate limit: 20 calls/second (1,200 calls/minute). A single request can get the data of up to 10 instances for up to 1,440 data points.
        /// If you need to call a large number of APIs to pull metrics or objects at a time, some APIs may fail to be called due to the rate limit. We suggest you evenly arrange API calls at a time granularity.
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public async Task<GetMonitorDataResponse> GetMonitorData(GetMonitorDataRequest req)
        {
             JsonResponseModel<GetMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<GetMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the command line for Prometheus agent management.
        /// </summary>
        /// <param name="req"><see cref="GetPrometheusAgentManagementCommandRequest"/></param>
        /// <returns><see cref="GetPrometheusAgentManagementCommandResponse"/></returns>
        public async Task<GetPrometheusAgentManagementCommandResponse> GetPrometheusAgentManagementCommand(GetPrometheusAgentManagementCommandRequest req)
        {
             JsonResponseModel<GetPrometheusAgentManagementCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPrometheusAgentManagementCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPrometheusAgentManagementCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the command line for Prometheus agent management.
        /// </summary>
        /// <param name="req"><see cref="GetPrometheusAgentManagementCommandRequest"/></param>
        /// <returns><see cref="GetPrometheusAgentManagementCommandResponse"/></returns>
        public GetPrometheusAgentManagementCommandResponse GetPrometheusAgentManagementCommandSync(GetPrometheusAgentManagementCommandRequest req)
        {
             JsonResponseModel<GetPrometheusAgentManagementCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPrometheusAgentManagementCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPrometheusAgentManagementCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to install a Grafana plugin.
        /// </summary>
        /// <param name="req"><see cref="InstallPluginsRequest"/></param>
        /// <returns><see cref="InstallPluginsResponse"/></returns>
        public async Task<InstallPluginsResponse> InstallPlugins(InstallPluginsRequest req)
        {
             JsonResponseModel<InstallPluginsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InstallPlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstallPluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to install a Grafana plugin.
        /// </summary>
        /// <param name="req"><see cref="InstallPluginsRequest"/></param>
        /// <returns><see cref="InstallPluginsResponse"/></returns>
        public InstallPluginsResponse InstallPluginsSync(InstallPluginsRequest req)
        {
             JsonResponseModel<InstallPluginsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InstallPlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InstallPluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to edit an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public async Task<ModifyAlarmNoticeResponse> ModifyAlarmNotice(ModifyAlarmNoticeRequest req)
        {
             JsonResponseModel<ModifyAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to edit an alarm notification template.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public ModifyAlarmNoticeResponse ModifyAlarmNoticeSync(ModifyAlarmNoticeRequest req)
        {
             JsonResponseModel<ModifyAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the trigger condition of an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyConditionRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyConditionResponse"/></returns>
        public async Task<ModifyAlarmPolicyConditionResponse> ModifyAlarmPolicyCondition(ModifyAlarmPolicyConditionRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyConditionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmPolicyCondition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyConditionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the trigger condition of an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyConditionRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyConditionResponse"/></returns>
        public ModifyAlarmPolicyConditionResponse ModifyAlarmPolicyConditionSync(ModifyAlarmPolicyConditionRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyConditionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmPolicyCondition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyConditionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to edit the basic information of a v2.0 alarm policy, including policy name and remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyInfoRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyInfoResponse"/></returns>
        public async Task<ModifyAlarmPolicyInfoResponse> ModifyAlarmPolicyInfo(ModifyAlarmPolicyInfoRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmPolicyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to edit the basic information of a v2.0 alarm policy, including policy name and remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyInfoRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyInfoResponse"/></returns>
        public ModifyAlarmPolicyInfoResponse ModifyAlarmPolicyInfoSync(ModifyAlarmPolicyInfoRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmPolicyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the alarm notification template bound to an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyNoticeResponse"/></returns>
        public async Task<ModifyAlarmPolicyNoticeResponse> ModifyAlarmPolicyNotice(ModifyAlarmPolicyNoticeRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmPolicyNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the alarm notification template bound to an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyNoticeResponse"/></returns>
        public ModifyAlarmPolicyNoticeResponse ModifyAlarmPolicyNoticeSync(ModifyAlarmPolicyNoticeRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmPolicyNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable/disable an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyStatusResponse"/></returns>
        public async Task<ModifyAlarmPolicyStatusResponse> ModifyAlarmPolicyStatus(ModifyAlarmPolicyStatusRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable/disable an alarm policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyStatusResponse"/></returns>
        public ModifyAlarmPolicyStatusResponse ModifyAlarmPolicyStatusSync(ModifyAlarmPolicyStatusRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the task triggered by an alarm policy. The `TriggerTasks` field contains the list of triggered tasks. If an empty array is passed in for `TriggerTasks`, it indicates to unbind all the triggered tasks from this policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyTasksRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyTasksResponse"/></returns>
        public async Task<ModifyAlarmPolicyTasksResponse> ModifyAlarmPolicyTasks(ModifyAlarmPolicyTasksRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmPolicyTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the task triggered by an alarm policy. The `TriggerTasks` field contains the list of triggered tasks. If an empty array is passed in for `TriggerTasks`, it indicates to unbind all the triggered tasks from this policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyTasksRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyTasksResponse"/></returns>
        public ModifyAlarmPolicyTasksResponse ModifyAlarmPolicyTasksSync(ModifyAlarmPolicyTasksRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmPolicyTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify alarm recipients.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public async Task<ModifyAlarmReceiversResponse> ModifyAlarmReceivers(ModifyAlarmReceiversRequest req)
        {
             JsonResponseModel<ModifyAlarmReceiversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify alarm recipients.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public ModifyAlarmReceiversResponse ModifyAlarmReceiversSync(ModifyAlarmReceiversRequest req)
        {
             JsonResponseModel<ModifyAlarmReceiversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ModifyGrafanaInstanceResponse"/></returns>
        public async Task<ModifyGrafanaInstanceResponse> ModifyGrafanaInstance(ModifyGrafanaInstanceRequest req)
        {
             JsonResponseModel<ModifyGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ModifyGrafanaInstanceResponse"/></returns>
        public ModifyGrafanaInstanceResponse ModifyGrafanaInstanceSync(ModifyGrafanaInstanceRequest req)
        {
             JsonResponseModel<ModifyGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update policy group.
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroup(ModifyPolicyGroupRequest req)
        {
             JsonResponseModel<ModifyPolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update policy group.
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public ModifyPolicyGroupResponse ModifyPolicyGroupSync(ModifyPolicyGroupRequest req)
        {
             JsonResponseModel<ModifyPolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the external labels of the associated cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAgentExternalLabelsRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAgentExternalLabelsResponse"/></returns>
        public async Task<ModifyPrometheusAgentExternalLabelsResponse> ModifyPrometheusAgentExternalLabels(ModifyPrometheusAgentExternalLabelsRequest req)
        {
             JsonResponseModel<ModifyPrometheusAgentExternalLabelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusAgentExternalLabels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusAgentExternalLabelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the external labels of the associated cluster.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAgentExternalLabelsRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAgentExternalLabelsResponse"/></returns>
        public ModifyPrometheusAgentExternalLabelsResponse ModifyPrometheusAgentExternalLabelsSync(ModifyPrometheusAgentExternalLabelsRequest req)
        {
             JsonResponseModel<ModifyPrometheusAgentExternalLabelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusAgentExternalLabels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusAgentExternalLabelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a TMP 2.0 instance alerting rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertPolicyResponse"/></returns>
        public async Task<ModifyPrometheusAlertPolicyResponse> ModifyPrometheusAlertPolicy(ModifyPrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<ModifyPrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a TMP 2.0 instance alerting rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertPolicyResponse"/></returns>
        public ModifyPrometheusAlertPolicyResponse ModifyPrometheusAlertPolicySync(ModifyPrometheusAlertPolicyRequest req)
        {
             JsonResponseModel<ModifyPrometheusAlertPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusAlertPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusAlertPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the Prometheus configuration. If there are no configuration items, one will be added.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusConfigRequest"/></param>
        /// <returns><see cref="ModifyPrometheusConfigResponse"/></returns>
        public async Task<ModifyPrometheusConfigResponse> ModifyPrometheusConfig(ModifyPrometheusConfigRequest req)
        {
             JsonResponseModel<ModifyPrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the Prometheus configuration. If there are no configuration items, one will be added.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusConfigRequest"/></param>
        /// <returns><see cref="ModifyPrometheusConfigResponse"/></returns>
        public ModifyPrometheusConfigResponse ModifyPrometheusConfigSync(ModifyPrometheusConfigRequest req)
        {
             JsonResponseModel<ModifyPrometheusConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="ModifyPrometheusGlobalNotificationResponse"/></returns>
        public async Task<ModifyPrometheusGlobalNotificationResponse> ModifyPrometheusGlobalNotification(ModifyPrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<ModifyPrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the global alert notification channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="ModifyPrometheusGlobalNotificationResponse"/></returns>
        public ModifyPrometheusGlobalNotificationResponse ModifyPrometheusGlobalNotificationSync(ModifyPrometheusGlobalNotificationRequest req)
        {
             JsonResponseModel<ModifyPrometheusGlobalNotificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusGlobalNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusGlobalNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyPrometheusInstanceAttributesResponse"/></returns>
        public async Task<ModifyPrometheusInstanceAttributesResponse> ModifyPrometheusInstanceAttributes(ModifyPrometheusInstanceAttributesRequest req)
        {
             JsonResponseModel<ModifyPrometheusInstanceAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusInstanceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusInstanceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyPrometheusInstanceAttributesResponse"/></returns>
        public ModifyPrometheusInstanceAttributesResponse ModifyPrometheusInstanceAttributesSync(ModifyPrometheusInstanceAttributesRequest req)
        {
             JsonResponseModel<ModifyPrometheusInstanceAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusInstanceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusInstanceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a Prometheus recording instance through YAML.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="ModifyPrometheusRecordRuleYamlResponse"/></returns>
        public async Task<ModifyPrometheusRecordRuleYamlResponse> ModifyPrometheusRecordRuleYaml(ModifyPrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<ModifyPrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a Prometheus recording instance through YAML.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="ModifyPrometheusRecordRuleYamlResponse"/></returns>
        public ModifyPrometheusRecordRuleYamlResponse ModifyPrometheusRecordRuleYamlSync(ModifyPrometheusRecordRuleYamlRequest req)
        {
             JsonResponseModel<ModifyPrometheusRecordRuleYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusRecordRuleYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusRecordRuleYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a template.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTempRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTempResponse"/></returns>
        public async Task<ModifyPrometheusTempResponse> ModifyPrometheusTemp(ModifyPrometheusTempRequest req)
        {
             JsonResponseModel<ModifyPrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a template.
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTempRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTempResponse"/></returns>
        public ModifyPrometheusTempResponse ModifyPrometheusTempSync(ModifyPrometheusTempRequest req)
        {
             JsonResponseModel<ModifyPrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// The default API request rate limit is 50 requests/sec.
        /// The default upper limit on metrics of a single tenant is 100.
        /// A maximum of 30 metric/value pairs can be reported at a time. When an error is returned for a request, no metrics/values in the request will be saved.
        /// 
        /// The reporting timestamp is the timestamp when you want to save the data. We recommend that you construct a timestamp at integer minutes.
        /// The time range of a timestamp is from 300 seconds before the current time to the current time.
        /// The data of the same IP metric/value pair must be reported by minute in chronological order.
        /// </summary>
        /// <param name="req"><see cref="PutMonitorDataRequest"/></param>
        /// <returns><see cref="PutMonitorDataResponse"/></returns>
        public async Task<PutMonitorDataResponse> PutMonitorData(PutMonitorDataRequest req)
        {
             JsonResponseModel<PutMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// The default API request rate limit is 50 requests/sec.
        /// The default upper limit on metrics of a single tenant is 100.
        /// A maximum of 30 metric/value pairs can be reported at a time. When an error is returned for a request, no metrics/values in the request will be saved.
        /// 
        /// The reporting timestamp is the timestamp when you want to save the data. We recommend that you construct a timestamp at integer minutes.
        /// The time range of a timestamp is from 300 seconds before the current time to the current time.
        /// The data of the same IP metric/value pair must be reported by minute in chronological order.
        /// </summary>
        /// <param name="req"><see cref="PutMonitorDataRequest"/></param>
        /// <returns><see cref="PutMonitorDataResponse"/></returns>
        public PutMonitorDataResponse PutMonitorDataSync(PutMonitorDataRequest req)
        {
             JsonResponseModel<PutMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="ResumeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ResumeGrafanaInstanceResponse"/></returns>
        public async Task<ResumeGrafanaInstanceResponse> ResumeGrafanaInstance(ResumeGrafanaInstanceRequest req)
        {
             JsonResponseModel<ResumeGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="ResumeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ResumeGrafanaInstanceResponse"/></returns>
        public ResumeGrafanaInstanceResponse ResumeGrafanaInstanceSync(ResumeGrafanaInstanceRequest req)
        {
             JsonResponseModel<ResumeGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to initialize a TMP instance, which is called when the integration center is enabled.
        /// </summary>
        /// <param name="req"><see cref="RunPrometheusInstanceRequest"/></param>
        /// <returns><see cref="RunPrometheusInstanceResponse"/></returns>
        public async Task<RunPrometheusInstanceResponse> RunPrometheusInstance(RunPrometheusInstanceRequest req)
        {
             JsonResponseModel<RunPrometheusInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunPrometheusInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunPrometheusInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to initialize a TMP instance, which is called when the integration center is enabled.
        /// </summary>
        /// <param name="req"><see cref="RunPrometheusInstanceRequest"/></param>
        /// <returns><see cref="RunPrometheusInstanceResponse"/></returns>
        public RunPrometheusInstanceResponse RunPrometheusInstanceSync(RunPrometheusInstanceRequest req)
        {
             JsonResponseModel<RunPrometheusInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunPrometheusInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunPrometheusInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a custom alarm notification.
        /// </summary>
        /// <param name="req"><see cref="SendCustomAlarmMsgRequest"/></param>
        /// <returns><see cref="SendCustomAlarmMsgResponse"/></returns>
        public async Task<SendCustomAlarmMsgResponse> SendCustomAlarmMsg(SendCustomAlarmMsgRequest req)
        {
             JsonResponseModel<SendCustomAlarmMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendCustomAlarmMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCustomAlarmMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a custom alarm notification.
        /// </summary>
        /// <param name="req"><see cref="SendCustomAlarmMsgRequest"/></param>
        /// <returns><see cref="SendCustomAlarmMsgResponse"/></returns>
        public SendCustomAlarmMsgResponse SendCustomAlarmMsgSync(SendCustomAlarmMsgRequest req)
        {
             JsonResponseModel<SendCustomAlarmMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendCustomAlarmMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCustomAlarmMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set an alarm policy as the default policy in the current policy type under the current project.
        /// Alarm policies in the same type under the project will be set as non-default.
        /// </summary>
        /// <param name="req"><see cref="SetDefaultAlarmPolicyRequest"/></param>
        /// <returns><see cref="SetDefaultAlarmPolicyResponse"/></returns>
        public async Task<SetDefaultAlarmPolicyResponse> SetDefaultAlarmPolicy(SetDefaultAlarmPolicyRequest req)
        {
             JsonResponseModel<SetDefaultAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetDefaultAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDefaultAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set an alarm policy as the default policy in the current policy type under the current project.
        /// Alarm policies in the same type under the project will be set as non-default.
        /// </summary>
        /// <param name="req"><see cref="SetDefaultAlarmPolicyRequest"/></param>
        /// <returns><see cref="SetDefaultAlarmPolicyResponse"/></returns>
        public SetDefaultAlarmPolicyResponse SetDefaultAlarmPolicySync(SetDefaultAlarmPolicyRequest req)
        {
             JsonResponseModel<SetDefaultAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetDefaultAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDefaultAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to sync a template to an instance or cluster. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTempRequest"/></param>
        /// <returns><see cref="SyncPrometheusTempResponse"/></returns>
        public async Task<SyncPrometheusTempResponse> SyncPrometheusTemp(SyncPrometheusTempRequest req)
        {
             JsonResponseModel<SyncPrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncPrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncPrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to sync a template to an instance or cluster. It takes effect for v2 instances.
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTempRequest"/></param>
        /// <returns><see cref="SyncPrometheusTempResponse"/></returns>
        public SyncPrometheusTempResponse SyncPrometheusTempSync(SyncPrometheusTempRequest req)
        {
             JsonResponseModel<SyncPrometheusTempResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncPrometheusTemp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncPrometheusTempResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="TerminatePrometheusInstancesRequest"/></param>
        /// <returns><see cref="TerminatePrometheusInstancesResponse"/></returns>
        public async Task<TerminatePrometheusInstancesResponse> TerminatePrometheusInstances(TerminatePrometheusInstancesRequest req)
        {
             JsonResponseModel<TerminatePrometheusInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminatePrometheusInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminatePrometheusInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go Prometheus instance.
        /// </summary>
        /// <param name="req"><see cref="TerminatePrometheusInstancesRequest"/></param>
        /// <returns><see cref="TerminatePrometheusInstancesResponse"/></returns>
        public TerminatePrometheusInstancesResponse TerminatePrometheusInstancesSync(TerminatePrometheusInstancesRequest req)
        {
             JsonResponseModel<TerminatePrometheusInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminatePrometheusInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminatePrometheusInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete all bound objects.
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public async Task<UnBindingAllPolicyObjectResponse> UnBindingAllPolicyObject(UnBindingAllPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingAllPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindingAllPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingAllPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete all bound objects.
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public UnBindingAllPolicyObjectResponse UnBindingAllPolicyObjectSync(UnBindingAllPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingAllPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindingAllPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingAllPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an object that is bound to a policy.
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public async Task<UnBindingPolicyObjectResponse> UnBindingPolicyObject(UnBindingPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an object that is bound to a policy.
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public UnBindingPolicyObjectResponse UnBindingPolicyObjectSync(UnBindingPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a Grafana instance from an instance.
        /// </summary>
        /// <param name="req"><see cref="UnbindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="UnbindPrometheusManagedGrafanaResponse"/></returns>
        public async Task<UnbindPrometheusManagedGrafanaResponse> UnbindPrometheusManagedGrafana(UnbindPrometheusManagedGrafanaRequest req)
        {
             JsonResponseModel<UnbindPrometheusManagedGrafanaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindPrometheusManagedGrafana");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindPrometheusManagedGrafanaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a Grafana instance from an instance.
        /// </summary>
        /// <param name="req"><see cref="UnbindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="UnbindPrometheusManagedGrafanaResponse"/></returns>
        public UnbindPrometheusManagedGrafanaResponse UnbindPrometheusManagedGrafanaSync(UnbindPrometheusManagedGrafanaRequest req)
        {
             JsonResponseModel<UnbindPrometheusManagedGrafanaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindPrometheusManagedGrafana");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindPrometheusManagedGrafanaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Grafana dashboard.
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UninstallGrafanaDashboardResponse"/></returns>
        public async Task<UninstallGrafanaDashboardResponse> UninstallGrafanaDashboard(UninstallGrafanaDashboardRequest req)
        {
             JsonResponseModel<UninstallGrafanaDashboardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UninstallGrafanaDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UninstallGrafanaDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a Grafana dashboard.
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UninstallGrafanaDashboardResponse"/></returns>
        public UninstallGrafanaDashboardResponse UninstallGrafanaDashboardSync(UninstallGrafanaDashboardRequest req)
        {
             JsonResponseModel<UninstallGrafanaDashboardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UninstallGrafanaDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UninstallGrafanaDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete installed plugins.
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaPluginsRequest"/></param>
        /// <returns><see cref="UninstallGrafanaPluginsResponse"/></returns>
        public async Task<UninstallGrafanaPluginsResponse> UninstallGrafanaPlugins(UninstallGrafanaPluginsRequest req)
        {
             JsonResponseModel<UninstallGrafanaPluginsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UninstallGrafanaPlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UninstallGrafanaPluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete installed plugins.
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaPluginsRequest"/></param>
        /// <returns><see cref="UninstallGrafanaPluginsResponse"/></returns>
        public UninstallGrafanaPluginsResponse UninstallGrafanaPluginsSync(UninstallGrafanaPluginsRequest req)
        {
             JsonResponseModel<UninstallGrafanaPluginsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UninstallGrafanaPlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UninstallGrafanaPluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a Prometheus alerting rule.
        /// 
        /// Note that alert object and alert message are special fields of Prometheus Rule Annotations, which need to be passed in through `annotations` and correspond to `summary` and `description` keys respectively. For more information, see [Alerting rules](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/).
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleResponse"/></returns>
        public async Task<UpdateAlertRuleResponse> UpdateAlertRule(UpdateAlertRuleRequest req)
        {
             JsonResponseModel<UpdateAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<UpdateAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the status of a Prometheus alerting rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleStateRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleStateResponse"/></returns>
        public async Task<UpdateAlertRuleStateResponse> UpdateAlertRuleState(UpdateAlertRuleStateRequest req)
        {
             JsonResponseModel<UpdateAlertRuleStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAlertRuleState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAlertRuleStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the status of a Prometheus alerting rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleStateRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleStateResponse"/></returns>
        public UpdateAlertRuleStateResponse UpdateAlertRuleStateSync(UpdateAlertRuleStateRequest req)
        {
             JsonResponseModel<UpdateAlertRuleStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAlertRuleState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAlertRuleStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the Grafana DNS configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateDNSConfigRequest"/></param>
        /// <returns><see cref="UpdateDNSConfigResponse"/></returns>
        public async Task<UpdateDNSConfigResponse> UpdateDNSConfig(UpdateDNSConfigRequest req)
        {
             JsonResponseModel<UpdateDNSConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDNSConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDNSConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the Grafana DNS configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateDNSConfigRequest"/></param>
        /// <returns><see cref="UpdateDNSConfigResponse"/></returns>
        public UpdateDNSConfigResponse UpdateDNSConfigSync(UpdateDNSConfigRequest req)
        {
             JsonResponseModel<UpdateDNSConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDNSConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDNSConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the exporter integration configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateExporterIntegrationRequest"/></param>
        /// <returns><see cref="UpdateExporterIntegrationResponse"/></returns>
        public async Task<UpdateExporterIntegrationResponse> UpdateExporterIntegration(UpdateExporterIntegrationRequest req)
        {
             JsonResponseModel<UpdateExporterIntegrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateExporterIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateExporterIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the exporter integration configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateExporterIntegrationRequest"/></param>
        /// <returns><see cref="UpdateExporterIntegrationResponse"/></returns>
        public UpdateExporterIntegrationResponse UpdateExporterIntegrationSync(UpdateExporterIntegrationRequest req)
        {
             JsonResponseModel<UpdateExporterIntegrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateExporterIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateExporterIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the Grafana configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaConfigRequest"/></param>
        /// <returns><see cref="UpdateGrafanaConfigResponse"/></returns>
        public async Task<UpdateGrafanaConfigResponse> UpdateGrafanaConfig(UpdateGrafanaConfigRequest req)
        {
             JsonResponseModel<UpdateGrafanaConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGrafanaConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGrafanaConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the Grafana configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaConfigRequest"/></param>
        /// <returns><see cref="UpdateGrafanaConfigResponse"/></returns>
        public UpdateGrafanaConfigResponse UpdateGrafanaConfigSync(UpdateGrafanaConfigRequest req)
        {
             JsonResponseModel<UpdateGrafanaConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGrafanaConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGrafanaConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update Grafana environment variables.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="UpdateGrafanaEnvironmentsResponse"/></returns>
        public async Task<UpdateGrafanaEnvironmentsResponse> UpdateGrafanaEnvironments(UpdateGrafanaEnvironmentsRequest req)
        {
             JsonResponseModel<UpdateGrafanaEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGrafanaEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGrafanaEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update Grafana environment variables.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="UpdateGrafanaEnvironmentsResponse"/></returns>
        public UpdateGrafanaEnvironmentsResponse UpdateGrafanaEnvironmentsSync(UpdateGrafanaEnvironmentsRequest req)
        {
             JsonResponseModel<UpdateGrafanaEnvironmentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGrafanaEnvironments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGrafanaEnvironmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="UpdateGrafanaIntegrationResponse"/></returns>
        public async Task<UpdateGrafanaIntegrationResponse> UpdateGrafanaIntegration(UpdateGrafanaIntegrationRequest req)
        {
             JsonResponseModel<UpdateGrafanaIntegrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGrafanaIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGrafanaIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the Grafana integration configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="UpdateGrafanaIntegrationResponse"/></returns>
        public UpdateGrafanaIntegrationResponse UpdateGrafanaIntegrationSync(UpdateGrafanaIntegrationRequest req)
        {
             JsonResponseModel<UpdateGrafanaIntegrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGrafanaIntegration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGrafanaIntegrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="UpdateGrafanaNotificationChannelResponse"/></returns>
        public async Task<UpdateGrafanaNotificationChannelResponse> UpdateGrafanaNotificationChannel(UpdateGrafanaNotificationChannelRequest req)
        {
             JsonResponseModel<UpdateGrafanaNotificationChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGrafanaNotificationChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGrafanaNotificationChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the Grafana notification channel.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="UpdateGrafanaNotificationChannelResponse"/></returns>
        public UpdateGrafanaNotificationChannelResponse UpdateGrafanaNotificationChannelSync(UpdateGrafanaNotificationChannelRequest req)
        {
             JsonResponseModel<UpdateGrafanaNotificationChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGrafanaNotificationChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGrafanaNotificationChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the Grafana allowlist.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="UpdateGrafanaWhiteListResponse"/></returns>
        public async Task<UpdateGrafanaWhiteListResponse> UpdateGrafanaWhiteList(UpdateGrafanaWhiteListRequest req)
        {
             JsonResponseModel<UpdateGrafanaWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGrafanaWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGrafanaWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the Grafana allowlist.
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="UpdateGrafanaWhiteListResponse"/></returns>
        public UpdateGrafanaWhiteListResponse UpdateGrafanaWhiteListSync(UpdateGrafanaWhiteListRequest req)
        {
             JsonResponseModel<UpdateGrafanaWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGrafanaWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGrafanaWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the status of a Prometheus CVM agent.
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusAgentStatusRequest"/></param>
        /// <returns><see cref="UpdatePrometheusAgentStatusResponse"/></returns>
        public async Task<UpdatePrometheusAgentStatusResponse> UpdatePrometheusAgentStatus(UpdatePrometheusAgentStatusRequest req)
        {
             JsonResponseModel<UpdatePrometheusAgentStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdatePrometheusAgentStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePrometheusAgentStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the status of a Prometheus CVM agent.
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusAgentStatusRequest"/></param>
        /// <returns><see cref="UpdatePrometheusAgentStatusResponse"/></returns>
        public UpdatePrometheusAgentStatusResponse UpdatePrometheusAgentStatusSync(UpdatePrometheusAgentStatusRequest req)
        {
             JsonResponseModel<UpdatePrometheusAgentStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdatePrometheusAgentStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePrometheusAgentStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="UpdatePrometheusScrapeJobResponse"/></returns>
        public async Task<UpdatePrometheusScrapeJobResponse> UpdatePrometheusScrapeJob(UpdatePrometheusScrapeJobRequest req)
        {
             JsonResponseModel<UpdatePrometheusScrapeJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdatePrometheusScrapeJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePrometheusScrapeJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a Prometheus scrape task.
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="UpdatePrometheusScrapeJobResponse"/></returns>
        public UpdatePrometheusScrapeJobResponse UpdatePrometheusScrapeJobSync(UpdatePrometheusScrapeJobRequest req)
        {
             JsonResponseModel<UpdatePrometheusScrapeJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdatePrometheusScrapeJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePrometheusScrapeJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a Prometheus recording rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordingRuleRequest"/></param>
        /// <returns><see cref="UpdateRecordingRuleResponse"/></returns>
        public async Task<UpdateRecordingRuleResponse> UpdateRecordingRule(UpdateRecordingRuleRequest req)
        {
             JsonResponseModel<UpdateRecordingRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRecordingRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecordingRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a Prometheus recording rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordingRuleRequest"/></param>
        /// <returns><see cref="UpdateRecordingRuleResponse"/></returns>
        public UpdateRecordingRuleResponse UpdateRecordingRuleSync(UpdateRecordingRuleRequest req)
        {
             JsonResponseModel<UpdateRecordingRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRecordingRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecordingRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the remarks and permission information of an authorized account in an overwriting manner.
        /// </summary>
        /// <param name="req"><see cref="UpdateSSOAccountRequest"/></param>
        /// <returns><see cref="UpdateSSOAccountResponse"/></returns>
        public async Task<UpdateSSOAccountResponse> UpdateSSOAccount(UpdateSSOAccountRequest req)
        {
             JsonResponseModel<UpdateSSOAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateSSOAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateSSOAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the remarks and permission information of an authorized account in an overwriting manner.
        /// </summary>
        /// <param name="req"><see cref="UpdateSSOAccountRequest"/></param>
        /// <returns><see cref="UpdateSSOAccountResponse"/></returns>
        public UpdateSSOAccountResponse UpdateSSOAccountSync(UpdateSSOAccountRequest req)
        {
             JsonResponseModel<UpdateSSOAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateSSOAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateSSOAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a Grafana dashboard.
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaDashboardResponse"/></returns>
        public async Task<UpgradeGrafanaDashboardResponse> UpgradeGrafanaDashboard(UpgradeGrafanaDashboardRequest req)
        {
             JsonResponseModel<UpgradeGrafanaDashboardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeGrafanaDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeGrafanaDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a Grafana dashboard.
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaDashboardResponse"/></returns>
        public UpgradeGrafanaDashboardResponse UpgradeGrafanaDashboardSync(UpgradeGrafanaDashboardRequest req)
        {
             JsonResponseModel<UpgradeGrafanaDashboardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeGrafanaDashboard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeGrafanaDashboardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaInstanceResponse"/></returns>
        public async Task<UpgradeGrafanaInstanceResponse> UpgradeGrafanaInstance(UpgradeGrafanaInstanceRequest req)
        {
             JsonResponseModel<UpgradeGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade a Grafana instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaInstanceResponse"/></returns>
        public UpgradeGrafanaInstanceResponse UpgradeGrafanaInstanceSync(UpgradeGrafanaInstanceRequest req)
        {
             JsonResponseModel<UpgradeGrafanaInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeGrafanaInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeGrafanaInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
