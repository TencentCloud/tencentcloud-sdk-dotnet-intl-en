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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemServiceVersionInfo : AbstractModel
    {
        
        /// <summary>
        /// Version ID
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Deployment mode
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// JDK version
        /// </summary>
        [JsonProperty("JdkVersion")]
        public string JdkVersion{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Deployed version
        /// </summary>
        [JsonProperty("DeployVersion")]
        public string DeployVersion{ get; set; }

        /// <summary>
        /// Publish mode
        /// </summary>
        [JsonProperty("PublishMode")]
        public string PublishMode{ get; set; }

        /// <summary>
        /// Launch parameter
        /// </summary>
        [JsonProperty("JvmOpts")]
        public string JvmOpts{ get; set; }

        /// <summary>
        /// Number of initial pods
        /// </summary>
        [JsonProperty("InitPodNum")]
        public long? InitPodNum{ get; set; }

        /// <summary>
        /// CPU specification
        /// </summary>
        [JsonProperty("CpuSpec")]
        public float? CpuSpec{ get; set; }

        /// <summary>
        /// Memory specification
        /// </summary>
        [JsonProperty("MemorySpec")]
        public float? MemorySpec{ get; set; }

        /// <summary>
        /// Image path
        /// </summary>
        [JsonProperty("ImgRepo")]
        public string ImgRepo{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImgName")]
        public string ImgName{ get; set; }

        /// <summary>
        /// Image version
        /// </summary>
        [JsonProperty("ImgVersion")]
        public string ImgVersion{ get; set; }

        /// <summary>
        /// Scaling configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EsInfo")]
        public EsInfo EsInfo{ get; set; }

        /// <summary>
        /// Environment configuration
        /// </summary>
        [JsonProperty("EnvConf")]
        public Pair[] EnvConf{ get; set; }

        /// <summary>
        /// Storage configuration
        /// </summary>
        [JsonProperty("StorageConfs")]
        public StorageConf[] StorageConfs{ get; set; }

        /// <summary>
        /// Running status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// VPC
        /// </summary>
        [JsonProperty("Vpc")]
        public string Vpc{ get; set; }

        /// <summary>
        /// Subnets
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateDate")]
        public string CreateDate{ get; set; }

        /// <summary>
        /// Modification time
        /// </summary>
        [JsonProperty("ModifyDate")]
        public string ModifyDate{ get; set; }

        /// <summary>
        /// Mounting configuration
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StorageMountConfs")]
        public StorageMountConf[] StorageMountConfs{ get; set; }

        /// <summary>
        /// Version name
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// Log output configuration
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogOutputConf")]
        public LogOutputConf LogOutputConf{ get; set; }

        /// <summary>
        /// Application name
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// Application description
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationDescription")]
        public string ApplicationDescription{ get; set; }

        /// <summary>
        /// Environment name
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnvironmentName")]
        public string EnvironmentName{ get; set; }

        /// <summary>
        /// Environment ID
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Public network address
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicDomain")]
        public string PublicDomain{ get; set; }

        /// <summary>
        /// Whether to enable public network access
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnablePublicAccess")]
        public bool? EnablePublicAccess{ get; set; }

        /// <summary>
        /// Number of current instances
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrentInstances")]
        public long? CurrentInstances{ get; set; }

        /// <summary>
        /// Number of expected instances
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpectedInstances")]
        public long? ExpectedInstances{ get; set; }

        /// <summary>
        /// Programming Language
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CodingLanguage")]
        public string CodingLanguage{ get; set; }

        /// <summary>
        /// Program package name
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PkgName")]
        public string PkgName{ get; set; }

        /// <summary>
        /// Whether to enable auto scaling
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EsEnable")]
        public long? EsEnable{ get; set; }

        /// <summary>
        /// Auto scaling policy
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EsStrategy")]
        public long? EsStrategy{ get; set; }

        /// <summary>
        /// Image tag
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// Whether to enable logging
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogEnable")]
        public long? LogEnable{ get; set; }

        /// <summary>
        /// Minimum number of instances
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinAliveInstances")]
        public string MinAliveInstances{ get; set; }

        /// <summary>
        /// Security group IDs
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Image command
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageCommand")]
        public string ImageCommand{ get; set; }

        /// <summary>
        /// Image command parameters
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageArgs")]
        public string[] ImageArgs{ get; set; }

        /// <summary>
        /// Whether to use the default registry configurations
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UseRegistryDefaultConfig")]
        public bool? UseRegistryDefaultConfig{ get; set; }

        /// <summary>
        /// EKS access configuration
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Service")]
        public EksService Service{ get; set; }

        /// <summary>
        /// Mounting configurations
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SettingConfs")]
        public MountedSettingConf[] SettingConfs{ get; set; }

        /// <summary>
        /// Log path information
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogConfs")]
        public string[] LogConfs{ get; set; }

        /// <summary>
        /// The script to execute right after the startup
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PostStart")]
        public string PostStart{ get; set; }

        /// <summary>
        /// The script to run before stop
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PreStop")]
        public string PreStop{ get; set; }

        /// <summary>
        /// Configuration of aliveness probe
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Liveness")]
        public HealthCheckConfig Liveness{ get; set; }

        /// <summary>
        /// Configuration of readiness probe
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Readiness")]
        public HealthCheckConfig Readiness{ get; set; }

        /// <summary>
        /// Auto scaling policy
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HorizontalAutoscaler")]
        public HorizontalAutoscaler[] HorizontalAutoscaler{ get; set; }

        /// <summary>
        /// Scheduled auto scaling policy
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CronHorizontalAutoscaler")]
        public CronHorizontalAutoscaler[] CronHorizontalAutoscaler{ get; set; }

        /// <summary>
        /// Availability zone of the application
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// The latest deployment time
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastDeployDate")]
        public string LastDeployDate{ get; set; }

        /// <summary>
        /// The latest successful deployment time
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastDeploySuccessDate")]
        public string LastDeploySuccessDate{ get; set; }

        /// <summary>
        /// Information of the node whether the application is deployed
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NodeInfos")]
        public NodeInfo[] NodeInfos{ get; set; }

        /// <summary>
        /// Image type. Values: `0` (Demo image), `1` (Normal image)
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageType")]
        public long? ImageType{ get; set; }

        /// <summary>
        /// Whether to 
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnableTracing")]
        public ulong? EnableTracing{ get; set; }

        /// <summary>
        /// (Disused) Whether to enable linkage tracing and report. It only takes effect when EnableTracing = `1`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnableTracingReport")]
        public ulong? EnableTracingReport{ get; set; }

        /// <summary>
        /// Image type. `0`: Individual image; `1`: Enterprise image; `2`: Public image
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RepoType")]
        public ulong? RepoType{ get; set; }

        /// <summary>
        /// Status of batch deployment: `batch_updating`, `batch_updating_waiting_confirm`
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BatchDeployStatus")]
        public string BatchDeployStatus{ get; set; }

        /// <summary>
        /// APM instance ID
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApmInstanceId")]
        public string ApmInstanceId{ get; set; }

        /// <summary>
        /// Workload information 
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkloadInfo")]
        public WorkloadInfo WorkloadInfo{ get; set; }

        /// <summary>
        /// Whether to enable application acceleration
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SpeedUp")]
        public bool? SpeedUp{ get; set; }

        /// <summary>
        /// Configuration of the startup probe
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartupProbe")]
        public HealthCheckConfig StartupProbe{ get; set; }

        /// <summary>
        /// OS version. Values:
        /// - ALPINE
        /// - CENTOS
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OsFlavour")]
        public string OsFlavour{ get; set; }

        /// <summary>
        /// Image repository server
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RepoServer")]
        public string RepoServer{ get; set; }

        /// <summary>
        /// Whether the application is being deployed
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnderDeploying")]
        public bool? UnderDeploying{ get; set; }

        /// <summary>
        /// Whether to enable application metric monitoring 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnablePrometheusConf")]
        public EnablePrometheusConf EnablePrometheusConf{ get; set; }

        /// <summary>
        /// Whether it’s stopped manually
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StoppedManually")]
        public bool? StoppedManually{ get; set; }

        /// <summary>
        /// TCR instance ID
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TcrInstanceId")]
        public string TcrInstanceId{ get; set; }

        /// <summary>
        /// `1`: Automatically enable metrics collection (open-telemetry)
        /// `0`: Disable metrics collection
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnableMetrics")]
        public long? EnableMetrics{ get; set; }

        /// <summary>
        /// User AppId
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// Sub Account UIN
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// User UIN
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Region
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Application group ID
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Whether to enable registry
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EnableRegistry")]
        public long? EnableRegistry{ get; set; }

        /// <summary>
        /// Array of scaling rules
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AutoscalerList")]
        public Autoscaler[] AutoscalerList{ get; set; }

        /// <summary>
        /// Modifier
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Modifier")]
        public string Modifier{ get; set; }

        /// <summary>
        /// Creator
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// Deployment strategy
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DeployStrategyConf")]
        public DeployStrategyConf DeployStrategyConf{ get; set; }

        /// <summary>
        /// List of pods
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PodList")]
        public DescribeRunPodPage PodList{ get; set; }

        /// <summary>
        /// Whether the configuration has been changed during deployment
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ConfEdited")]
        public bool? ConfEdited{ get; set; }

        /// <summary>
        /// Tag
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Whether to encode
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PreStopEncoded")]
        public string PreStopEncoded{ get; set; }

        /// <summary>
        /// Whether to encode
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PostStartEncoded")]
        public string PostStartEncoded{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "JdkVersion", this.JdkVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DeployVersion", this.DeployVersion);
            this.SetParamSimple(map, prefix + "PublishMode", this.PublishMode);
            this.SetParamSimple(map, prefix + "JvmOpts", this.JvmOpts);
            this.SetParamSimple(map, prefix + "InitPodNum", this.InitPodNum);
            this.SetParamSimple(map, prefix + "CpuSpec", this.CpuSpec);
            this.SetParamSimple(map, prefix + "MemorySpec", this.MemorySpec);
            this.SetParamSimple(map, prefix + "ImgRepo", this.ImgRepo);
            this.SetParamSimple(map, prefix + "ImgName", this.ImgName);
            this.SetParamSimple(map, prefix + "ImgVersion", this.ImgVersion);
            this.SetParamObj(map, prefix + "EsInfo.", this.EsInfo);
            this.SetParamArrayObj(map, prefix + "EnvConf.", this.EnvConf);
            this.SetParamArrayObj(map, prefix + "StorageConfs.", this.StorageConfs);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Vpc", this.Vpc);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CreateDate", this.CreateDate);
            this.SetParamSimple(map, prefix + "ModifyDate", this.ModifyDate);
            this.SetParamArrayObj(map, prefix + "StorageMountConfs.", this.StorageMountConfs);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamObj(map, prefix + "LogOutputConf.", this.LogOutputConf);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationDescription", this.ApplicationDescription);
            this.SetParamSimple(map, prefix + "EnvironmentName", this.EnvironmentName);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "PublicDomain", this.PublicDomain);
            this.SetParamSimple(map, prefix + "EnablePublicAccess", this.EnablePublicAccess);
            this.SetParamSimple(map, prefix + "CurrentInstances", this.CurrentInstances);
            this.SetParamSimple(map, prefix + "ExpectedInstances", this.ExpectedInstances);
            this.SetParamSimple(map, prefix + "CodingLanguage", this.CodingLanguage);
            this.SetParamSimple(map, prefix + "PkgName", this.PkgName);
            this.SetParamSimple(map, prefix + "EsEnable", this.EsEnable);
            this.SetParamSimple(map, prefix + "EsStrategy", this.EsStrategy);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamSimple(map, prefix + "MinAliveInstances", this.MinAliveInstances);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "ImageCommand", this.ImageCommand);
            this.SetParamArraySimple(map, prefix + "ImageArgs.", this.ImageArgs);
            this.SetParamSimple(map, prefix + "UseRegistryDefaultConfig", this.UseRegistryDefaultConfig);
            this.SetParamObj(map, prefix + "Service.", this.Service);
            this.SetParamArrayObj(map, prefix + "SettingConfs.", this.SettingConfs);
            this.SetParamArraySimple(map, prefix + "LogConfs.", this.LogConfs);
            this.SetParamSimple(map, prefix + "PostStart", this.PostStart);
            this.SetParamSimple(map, prefix + "PreStop", this.PreStop);
            this.SetParamObj(map, prefix + "Liveness.", this.Liveness);
            this.SetParamObj(map, prefix + "Readiness.", this.Readiness);
            this.SetParamArrayObj(map, prefix + "HorizontalAutoscaler.", this.HorizontalAutoscaler);
            this.SetParamArrayObj(map, prefix + "CronHorizontalAutoscaler.", this.CronHorizontalAutoscaler);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "LastDeployDate", this.LastDeployDate);
            this.SetParamSimple(map, prefix + "LastDeploySuccessDate", this.LastDeploySuccessDate);
            this.SetParamArrayObj(map, prefix + "NodeInfos.", this.NodeInfos);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "EnableTracing", this.EnableTracing);
            this.SetParamSimple(map, prefix + "EnableTracingReport", this.EnableTracingReport);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamSimple(map, prefix + "BatchDeployStatus", this.BatchDeployStatus);
            this.SetParamSimple(map, prefix + "ApmInstanceId", this.ApmInstanceId);
            this.SetParamObj(map, prefix + "WorkloadInfo.", this.WorkloadInfo);
            this.SetParamSimple(map, prefix + "SpeedUp", this.SpeedUp);
            this.SetParamObj(map, prefix + "StartupProbe.", this.StartupProbe);
            this.SetParamSimple(map, prefix + "OsFlavour", this.OsFlavour);
            this.SetParamSimple(map, prefix + "RepoServer", this.RepoServer);
            this.SetParamSimple(map, prefix + "UnderDeploying", this.UnderDeploying);
            this.SetParamObj(map, prefix + "EnablePrometheusConf.", this.EnablePrometheusConf);
            this.SetParamSimple(map, prefix + "StoppedManually", this.StoppedManually);
            this.SetParamSimple(map, prefix + "TcrInstanceId", this.TcrInstanceId);
            this.SetParamSimple(map, prefix + "EnableMetrics", this.EnableMetrics);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "EnableRegistry", this.EnableRegistry);
            this.SetParamArrayObj(map, prefix + "AutoscalerList.", this.AutoscalerList);
            this.SetParamSimple(map, prefix + "Modifier", this.Modifier);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamObj(map, prefix + "DeployStrategyConf.", this.DeployStrategyConf);
            this.SetParamObj(map, prefix + "PodList.", this.PodList);
            this.SetParamSimple(map, prefix + "ConfEdited", this.ConfEdited);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "PreStopEncoded", this.PreStopEncoded);
            this.SetParamSimple(map, prefix + "PostStartEncoded", this.PostStartEncoded);
        }
    }
}

