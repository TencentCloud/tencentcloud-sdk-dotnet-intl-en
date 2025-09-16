/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceInfo : AbstractModel
    {
        
        /// <summary>
        /// Expected number of running Pods. The instance is 0 when the stop status is reached.Corresponding relationships under different billing and scaling modes are as follows.PREPAID and POSTPAID_BY_HOUR:Corresponding number of instances in the manual scaling mode.Corresponding number of instances based on the default time-based policy in the auto-scaling mode.HYBRID_PAID:
        /// Corresponding number of instances for postpaid instances in the manual scaling mode.Corresponding number of instances under the default time-based policy for postpaid instances in the auto-scaling mode.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// Image information.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// Environment variables.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Env")]
        public EnvVar[] Env{ get; set; }

        /// <summary>
        /// Resource information.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Resources")]
        public ResourceInfo Resources{ get; set; }

        /// <summary>
        /// Type specifications corresponding to the postpaid instance.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Model information.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModelInfo")]
        public ModelInfo ModelInfo{ get; set; }

        /// <summary>
        /// Whether to enable logs.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogEnable")]
        public bool? LogEnable{ get; set; }

        /// <summary>
        /// Log configurations.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogConfig")]
        public LogConfig LogConfig{ get; set; }

        /// <summary>
        /// Whether to enable authentication.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthorizationEnable")]
        public bool? AuthorizationEnable{ get; set; }

        /// <summary>
        /// HPA configurations.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HorizontalPodAutoscaler")]
        public HorizontalPodAutoscaler HorizontalPodAutoscaler{ get; set; }

        /// <summary>
        /// Description of the service status.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public WorkloadStatus Status{ get; set; }

        /// <summary>
        /// Weight.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// Total resources.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceTotal")]
        public ResourceInfo ResourceTotal{ get; set; }

        /// <summary>
        /// Number of historical instances.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OldReplicas")]
        public long? OldReplicas{ get; set; }

        /// <summary>
        /// This parameter is valid when the billing mode is HYBRID_PAID, and is used to identify the number of prepaid instances in the hybrid billing mode. The default value is 1 if this parameter is left unspecified.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HybridBillingPrepaidReplicas")]
        public long? HybridBillingPrepaidReplicas{ get; set; }

        /// <summary>
        /// Number of instances during the historical HYBRID_PAID period. The user restores services.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OldHybridBillingPrepaidReplicas")]
        public long? OldHybridBillingPrepaidReplicas{ get; set; }

        /// <summary>
        /// Whether to enable hot update for the model. By default, hot update is disabled.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModelHotUpdateEnable")]
        public bool? ModelHotUpdateEnable{ get; set; }

        /// <summary>
        /// Service specification alias.
        /// </summary>
        [JsonProperty("InstanceAlias")]
        public string InstanceAlias{ get; set; }

        /// <summary>
        /// Instance quantity adjusting mode. Defaults to manual.Supported valid values: AUTO (automatic), MANUAL (manual).Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScaleMode")]
        public string ScaleMode{ get; set; }

        /// <summary>
        /// Scheduled scaling task.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CronScaleJobs")]
        public CronScaleJob[] CronScaleJobs{ get; set; }

        /// <summary>
        /// Scheduled scaling policy.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScaleStrategy")]
        public string ScaleStrategy{ get; set; }

        /// <summary>
        /// Configurations of the scheduled stop.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScheduledAction")]
        public ScheduledAction ScheduledAction{ get; set; }

        /// <summary>
        /// Instance list.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PodList")]
        [System.Obsolete]
        public string[] PodList{ get; set; }

        /// <summary>
        /// Pod list information.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Pods")]
        [System.Obsolete]
        public Pod Pods{ get; set; }

        /// <summary>
        /// Pod list information.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PodInfos")]
        public Pod[] PodInfos{ get; set; }

        /// <summary>
        /// Configurations related to speed limit and throttling of services.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceLimit")]
        public ServiceLimit ServiceLimit{ get; set; }

        /// <summary>
        /// Whether to enable model acceleration, which is only valid for models in the StableDiffusion (dynamic acceleration) format.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModelTurboEnable")]
        public bool? ModelTurboEnable{ get; set; }

        /// <summary>
        /// Mounting.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VolumeMount")]
        public VolumeMount VolumeMount{ get; set; }

        /// <summary>
        /// Inference code information.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InferCodeInfo")]
        public InferCodeInfo InferCodeInfo{ get; set; }

        /// <summary>
        /// Service startup command.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// Settings of enabling the TI-ONE private network to access external resources.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceEIP")]
        public ServiceEIP ServiceEIP{ get; set; }

        /// <summary>
        /// Service port, with the default value of 8501.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServicePort")]
        public long? ServicePort{ get; set; }

        /// <summary>
        /// Graceful exit time limit of the service, in seconds. Default value: 30. Minimum value: 1.
        /// </summary>
        [JsonProperty("TerminationGracePeriodSeconds")]
        public long? TerminationGracePeriodSeconds{ get; set; }

        /// <summary>
        /// Command executed before the service instance stops. The instance ends after the command execution is completed or after the execution time exceeds the graceful exit time limit.
        /// </summary>
        [JsonProperty("PreStopCommand")]
        public string[] PreStopCommand{ get; set; }

        /// <summary>
        /// Whether to enable the gRPC port.
        /// </summary>
        [JsonProperty("GrpcEnable")]
        public bool? GrpcEnable{ get; set; }

        /// <summary>
        /// Health probe.
        /// </summary>
        [JsonProperty("HealthProbe")]
        public HealthProbe HealthProbe{ get; set; }

        /// <summary>
        /// Rolling update configurations.
        /// </summary>
        [JsonProperty("RollingUpdate")]
        public RollingUpdate RollingUpdate{ get; set; }

        /// <summary>
        /// Number of instances per replica. This parameter is valid only when the deployment type is DIST or ROLE. Default value: 1.
        /// </summary>
        [JsonProperty("InstancePerReplicas")]
        public long? InstancePerReplicas{ get; set; }

        /// <summary>
        /// Batch data disk mounting configurations.
        /// </summary>
        [JsonProperty("VolumeMounts")]
        public VolumeMount[] VolumeMounts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamArrayObj(map, prefix + "Env.", this.Env);
            this.SetParamObj(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "ModelInfo.", this.ModelInfo);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "AuthorizationEnable", this.AuthorizationEnable);
            this.SetParamObj(map, prefix + "HorizontalPodAutoscaler.", this.HorizontalPodAutoscaler);
            this.SetParamObj(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamObj(map, prefix + "ResourceTotal.", this.ResourceTotal);
            this.SetParamSimple(map, prefix + "OldReplicas", this.OldReplicas);
            this.SetParamSimple(map, prefix + "HybridBillingPrepaidReplicas", this.HybridBillingPrepaidReplicas);
            this.SetParamSimple(map, prefix + "OldHybridBillingPrepaidReplicas", this.OldHybridBillingPrepaidReplicas);
            this.SetParamSimple(map, prefix + "ModelHotUpdateEnable", this.ModelHotUpdateEnable);
            this.SetParamSimple(map, prefix + "InstanceAlias", this.InstanceAlias);
            this.SetParamSimple(map, prefix + "ScaleMode", this.ScaleMode);
            this.SetParamArrayObj(map, prefix + "CronScaleJobs.", this.CronScaleJobs);
            this.SetParamSimple(map, prefix + "ScaleStrategy", this.ScaleStrategy);
            this.SetParamObj(map, prefix + "ScheduledAction.", this.ScheduledAction);
            this.SetParamArraySimple(map, prefix + "PodList.", this.PodList);
            this.SetParamObj(map, prefix + "Pods.", this.Pods);
            this.SetParamArrayObj(map, prefix + "PodInfos.", this.PodInfos);
            this.SetParamObj(map, prefix + "ServiceLimit.", this.ServiceLimit);
            this.SetParamSimple(map, prefix + "ModelTurboEnable", this.ModelTurboEnable);
            this.SetParamObj(map, prefix + "VolumeMount.", this.VolumeMount);
            this.SetParamObj(map, prefix + "InferCodeInfo.", this.InferCodeInfo);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamObj(map, prefix + "ServiceEIP.", this.ServiceEIP);
            this.SetParamSimple(map, prefix + "ServicePort", this.ServicePort);
            this.SetParamSimple(map, prefix + "TerminationGracePeriodSeconds", this.TerminationGracePeriodSeconds);
            this.SetParamArraySimple(map, prefix + "PreStopCommand.", this.PreStopCommand);
            this.SetParamSimple(map, prefix + "GrpcEnable", this.GrpcEnable);
            this.SetParamObj(map, prefix + "HealthProbe.", this.HealthProbe);
            this.SetParamObj(map, prefix + "RollingUpdate.", this.RollingUpdate);
            this.SetParamSimple(map, prefix + "InstancePerReplicas", this.InstancePerReplicas);
            this.SetParamArrayObj(map, prefix + "VolumeMounts.", this.VolumeMounts);
        }
    }
}

