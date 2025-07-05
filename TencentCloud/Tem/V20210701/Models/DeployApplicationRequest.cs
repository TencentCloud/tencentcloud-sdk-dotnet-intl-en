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

    public class DeployApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Number of initialized pods
        /// </summary>
        [JsonProperty("InitPodNum")]
        public ulong? InitPodNum{ get; set; }

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
        /// Environment ID
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Image repository
        /// </summary>
        [JsonProperty("ImgRepo")]
        public string ImgRepo{ get; set; }

        /// <summary>
        /// Version description
        /// </summary>
        [JsonProperty("VersionDesc")]
        public string VersionDesc{ get; set; }

        /// <summary>
        /// Launch parameters
        /// </summary>
        [JsonProperty("JvmOpts")]
        public string JvmOpts{ get; set; }

        /// <summary>
        /// Auto scaling configuration (This field is disused. Please use `HorizontalAutoscaler` to set the auto scaling policy.)
        /// </summary>
        [JsonProperty("EsInfo")]
        public EsInfo EsInfo{ get; set; }

        /// <summary>
        /// Environment variable configuration
        /// </summary>
        [JsonProperty("EnvConf")]
        public Pair[] EnvConf{ get; set; }

        /// <summary>
        /// Log configuration
        /// </summary>
        [JsonProperty("LogConfs")]
        public string[] LogConfs{ get; set; }

        /// <summary>
        /// Data volume configuration
        /// </summary>
        [JsonProperty("StorageConfs")]
        public StorageConf[] StorageConfs{ get; set; }

        /// <summary>
        /// Data volume mount configuration
        /// </summary>
        [JsonProperty("StorageMountConfs")]
        public StorageMountConf[] StorageMountConfs{ get; set; }

        /// <summary>
        /// Deployment type
        /// - JAR: deployment through JAR package
        /// - WAR: deployment through WAR package
        /// - IMAGE: deployment through image
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// When the deployment type is `IMAGE`, this parameter indicates the image tag
        /// When the deployment type is `JAR` or `WAR`, this parameter indicates the package version number
        /// </summary>
        [JsonProperty("DeployVersion")]
        public string DeployVersion{ get; set; }

        /// <summary>
        /// Package name, which is required when using JAR or WAR packages for deployment
        /// </summary>
        [JsonProperty("PkgName")]
        public string PkgName{ get; set; }

        /// <summary>
        /// JDK version
        /// - KONA: use KONA JDK
        /// - OPEN: use open JDK
        /// - KONA: use KONA JDK
        /// - OPEN: use open JDK
        /// </summary>
        [JsonProperty("JdkVersion")]
        public string JdkVersion{ get; set; }

        /// <summary>
        /// Security group IDs
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Log output configuration
        /// </summary>
        [JsonProperty("LogOutputConf")]
        public LogOutputConf LogOutputConf{ get; set; }

        /// <summary>
        /// Source channel
        /// </summary>
        [JsonProperty("SourceChannel")]
        public long? SourceChannel{ get; set; }

        /// <summary>
        /// Version description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Image command
        /// </summary>
        [JsonProperty("ImageCommand")]
        public string ImageCommand{ get; set; }

        /// <summary>
        /// Image command parameters
        /// </summary>
        [JsonProperty("ImageArgs")]
        public string[] ImageArgs{ get; set; }

        /// <summary>
        /// Whether to add the registry's default configurations
        /// </summary>
        [JsonProperty("UseRegistryDefaultConfig")]
        public bool? UseRegistryDefaultConfig{ get; set; }

        /// <summary>
        /// Mounting configurations
        /// </summary>
        [JsonProperty("SettingConfs")]
        public MountedSettingConf[] SettingConfs{ get; set; }

        /// <summary>
        /// Application access configuration
        /// </summary>
        [JsonProperty("Service")]
        public EksService Service{ get; set; }

        /// <summary>
        /// ID of the version that you want to roll back to
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// The script to run after startup
        /// </summary>
        [JsonProperty("PostStart")]
        public string PostStart{ get; set; }

        /// <summary>
        /// The script to run before stop
        /// </summary>
        [JsonProperty("PreStop")]
        public string PreStop{ get; set; }

        /// <summary>
        /// Configuration of aliveness probe
        /// </summary>
        [JsonProperty("Liveness")]
        public HealthCheckConfig Liveness{ get; set; }

        /// <summary>
        /// Configuration of readiness probe
        /// </summary>
        [JsonProperty("Readiness")]
        public HealthCheckConfig Readiness{ get; set; }

        /// <summary>
        /// Configuration of batch release policies
        /// </summary>
        [JsonProperty("DeployStrategyConf")]
        public DeployStrategyConf DeployStrategyConf{ get; set; }

        /// <summary>
        /// Auto scaling policy. (Disused. Please use APIs for auto scaling policy combinations)
        /// </summary>
        [JsonProperty("HorizontalAutoscaler")]
        public HorizontalAutoscaler[] HorizontalAutoscaler{ get; set; }

        /// <summary>
        /// Scheduled scaling policy (Disused. Please use APIs for auto scaling policy combinations)
        /// </summary>
        [JsonProperty("CronHorizontalAutoscaler")]
        public CronHorizontalAutoscaler[] CronHorizontalAutoscaler{ get; set; }

        /// <summary>
        /// Specifies whether to enable logging. `1`: enable; `0`: do not enable
        /// </summary>
        [JsonProperty("LogEnable")]
        public long? LogEnable{ get; set; }

        /// <summary>
        /// Whether the configuration is modified (except for the image configuration)
        /// </summary>
        [JsonProperty("ConfEdited")]
        public bool? ConfEdited{ get; set; }

        /// <summary>
        /// Whether the application acceleration is enabled 
        /// </summary>
        [JsonProperty("SpeedUp")]
        public bool? SpeedUp{ get; set; }

        /// <summary>
        /// Whether to enable probing
        /// </summary>
        [JsonProperty("StartupProbe")]
        public HealthCheckConfig StartupProbe{ get; set; }

        /// <summary>
        /// The version of the operating system
        /// If `openjdk` is selected, the value can be: 
        /// - ALPINE
        /// - CENTOS
        /// If `konajdk` is selected, the value can be: 
        /// - ALPINE
        /// - TENCENTOS
        /// </summary>
        [JsonProperty("OsFlavour")]
        public string OsFlavour{ get; set; }

        /// <summary>
        /// Configuration of metrics of this application
        /// </summary>
        [JsonProperty("EnablePrometheusConf")]
        public EnablePrometheusConf EnablePrometheusConf{ get; set; }

        /// <summary>
        /// `1`: Automatically enable APM tracing (Skywalking)
        /// `0`: Disable APM tracing
        /// </summary>
        [JsonProperty("EnableTracing")]
        public long? EnableTracing{ get; set; }

        /// <summary>
        /// `1`: Automatically enable metrics collection (open-telemetry)
        /// `0`: Disable metrics collection
        /// </summary>
        [JsonProperty("EnableMetrics")]
        public long? EnableMetrics{ get; set; }

        /// <summary>
        /// ID of the TCR instance used for image deployment
        /// </summary>
        [JsonProperty("TcrInstanceId")]
        public string TcrInstanceId{ get; set; }

        /// <summary>
        /// Image server address for image deployment
        /// </summary>
        [JsonProperty("RepoServer")]
        public string RepoServer{ get; set; }

        /// <summary>
        /// Type of the repository. `0`: TCR Personal; `1`: TCR Enterprise; `2`: Public repository; `3`: TEM hosted repository; `4`: Demo repository
        /// </summary>
        [JsonProperty("RepoType")]
        public long? RepoType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "InitPodNum", this.InitPodNum);
            this.SetParamSimple(map, prefix + "CpuSpec", this.CpuSpec);
            this.SetParamSimple(map, prefix + "MemorySpec", this.MemorySpec);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "ImgRepo", this.ImgRepo);
            this.SetParamSimple(map, prefix + "VersionDesc", this.VersionDesc);
            this.SetParamSimple(map, prefix + "JvmOpts", this.JvmOpts);
            this.SetParamObj(map, prefix + "EsInfo.", this.EsInfo);
            this.SetParamArrayObj(map, prefix + "EnvConf.", this.EnvConf);
            this.SetParamArraySimple(map, prefix + "LogConfs.", this.LogConfs);
            this.SetParamArrayObj(map, prefix + "StorageConfs.", this.StorageConfs);
            this.SetParamArrayObj(map, prefix + "StorageMountConfs.", this.StorageMountConfs);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "DeployVersion", this.DeployVersion);
            this.SetParamSimple(map, prefix + "PkgName", this.PkgName);
            this.SetParamSimple(map, prefix + "JdkVersion", this.JdkVersion);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "LogOutputConf.", this.LogOutputConf);
            this.SetParamSimple(map, prefix + "SourceChannel", this.SourceChannel);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ImageCommand", this.ImageCommand);
            this.SetParamArraySimple(map, prefix + "ImageArgs.", this.ImageArgs);
            this.SetParamSimple(map, prefix + "UseRegistryDefaultConfig", this.UseRegistryDefaultConfig);
            this.SetParamArrayObj(map, prefix + "SettingConfs.", this.SettingConfs);
            this.SetParamObj(map, prefix + "Service.", this.Service);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "PostStart", this.PostStart);
            this.SetParamSimple(map, prefix + "PreStop", this.PreStop);
            this.SetParamObj(map, prefix + "Liveness.", this.Liveness);
            this.SetParamObj(map, prefix + "Readiness.", this.Readiness);
            this.SetParamObj(map, prefix + "DeployStrategyConf.", this.DeployStrategyConf);
            this.SetParamArrayObj(map, prefix + "HorizontalAutoscaler.", this.HorizontalAutoscaler);
            this.SetParamArrayObj(map, prefix + "CronHorizontalAutoscaler.", this.CronHorizontalAutoscaler);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamSimple(map, prefix + "ConfEdited", this.ConfEdited);
            this.SetParamSimple(map, prefix + "SpeedUp", this.SpeedUp);
            this.SetParamObj(map, prefix + "StartupProbe.", this.StartupProbe);
            this.SetParamSimple(map, prefix + "OsFlavour", this.OsFlavour);
            this.SetParamObj(map, prefix + "EnablePrometheusConf.", this.EnablePrometheusConf);
            this.SetParamSimple(map, prefix + "EnableTracing", this.EnableTracing);
            this.SetParamSimple(map, prefix + "EnableMetrics", this.EnableMetrics);
            this.SetParamSimple(map, prefix + "TcrInstanceId", this.TcrInstanceId);
            this.SetParamSimple(map, prefix + "RepoServer", this.RepoServer);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
        }
    }
}

