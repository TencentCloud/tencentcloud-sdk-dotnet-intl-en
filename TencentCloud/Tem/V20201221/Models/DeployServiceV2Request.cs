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

namespace TencentCloud.Tem.V20201221.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployServiceV2Request : AbstractModel
    {
        
        /// <summary>
        /// Service ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Container port
        /// </summary>
        [JsonProperty("ContainerPort")]
        public ulong? ContainerPort{ get; set; }

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
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

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
        /// Auto scaling configuration. If this parameter is left empty, auto scaling will not be enabled
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
        /// Deployment type.
        /// - JAR: deployment through JAR package
        /// - WAR: deployment through WAR package
        /// - IMAGE: deployment through image
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// When the deployment type is `IMAGE`, this parameter indicates the image tag.
        /// When the deployment type is `JAR` or `WAR`, this parameter indicates the package version number.
        /// </summary>
        [JsonProperty("DeployVersion")]
        public string DeployVersion{ get; set; }

        /// <summary>
        /// Package name, which is required when using JAR or WAR packages for deployment.
        /// </summary>
        [JsonProperty("PkgName")]
        public string PkgName{ get; set; }

        /// <summary>
        /// JDK version.
        /// - KONA: use KONA JDK.
        /// - OPEN: use open JDK.
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
        /// Service port mapping.
        /// </summary>
        [JsonProperty("PortMappings")]
        public PortMapping[] PortMappings{ get; set; }

        /// <summary>
        /// Whether to add the registry’s default configurations.
        /// </summary>
        [JsonProperty("UseRegistryDefaultConfig")]
        public bool? UseRegistryDefaultConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SettingConfs")]
        public MountedSettingConf[] SettingConfs{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EksService")]
        public EksService EksService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ContainerPort", this.ContainerPort);
            this.SetParamSimple(map, prefix + "InitPodNum", this.InitPodNum);
            this.SetParamSimple(map, prefix + "CpuSpec", this.CpuSpec);
            this.SetParamSimple(map, prefix + "MemorySpec", this.MemorySpec);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
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
            this.SetParamArrayObj(map, prefix + "PortMappings.", this.PortMappings);
            this.SetParamSimple(map, prefix + "UseRegistryDefaultConfig", this.UseRegistryDefaultConfig);
            this.SetParamArrayObj(map, prefix + "SettingConfs.", this.SettingConfs);
            this.SetParamObj(map, prefix + "EksService.", this.EksService);
        }
    }
}

