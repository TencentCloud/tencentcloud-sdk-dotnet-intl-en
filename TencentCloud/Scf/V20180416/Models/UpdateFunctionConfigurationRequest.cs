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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateFunctionConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// The function name to be modified
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Function description. Supports up to 1,000 English letters, digits, spaces, commas, and periods. Chinese is supported.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Memory size of the function runtime. Default value: 128 MB. Selectable range: 64 MB, or 128 MB to 3072 MB in 128 MB increments.
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// Maximum execution time of the function, in seconds. Value range: 1-900 seconds. Default value: 3 seconds.
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// Runtime environment. It is specified upon creation and currently does not support modification.
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// Environment variable of the function
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment{ get; set; }

        /// <summary>
        /// Namespace of the function
        /// Default value: default
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// VPC configuration of the function
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// Role bound to a function
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// [Install dependency online](https://www.tencentcloud.com/document/product/583/37920?from_cn_redirect=1). TRUE indicates installation. Default value: FALSE. Only supported for Node.js functions.
        /// </summary>
        [JsonProperty("InstallDependency")]
        public string InstallDependency{ get; set; }

        /// <summary>
        /// ID of the cls Log Set for log delivery
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// cls Topic ID for log delivery
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// Whether to release a new version synchronously when updating. Default value: FALSE, which means no new version is released.
        /// </summary>
        [JsonProperty("Publish")]
        public string Publish{ get; set; }

        /// <summary>
        /// Whether L5 access capability is enabled. TRUE to enable, FALSE to shutdown.
        /// </summary>
        [JsonProperty("L5Enable")]
        public string L5Enable{ get; set; }

        /// <summary>
        /// List of layer versions to associate with the function. The layer versions overwrite each other sequentially in the order in the list.
        /// </summary>
        [JsonProperty("Layers")]
        public LayerVersionSimple[] Layers{ get; set; }

        /// <summary>
        /// Dead letter queue information associated with the function
        /// </summary>
        [JsonProperty("DeadLetterConfig")]
        public DeadLetterConfig DeadLetterConfig{ get; set; }

        /// <summary>
        /// Public network access configuration
        /// </summary>
        [JsonProperty("PublicNetConfig")]
        public PublicNetConfigIn PublicNetConfig{ get; set; }

        /// <summary>
        /// File system configuration parameters for binding a CFS file system in SCF
        /// </summary>
        [JsonProperty("CfsConfig")]
        public CfsConfig CfsConfig{ get; set; }

        /// <summary>
        /// Function initialization timeout period
        /// </summary>
        [JsonProperty("InitTimeout")]
        public long? InitTimeout{ get; set; }

        /// <summary>
        /// Configure ProtocolType access protocol for an HTTP function. Parameters configurable for the current protocol.
        /// </summary>
        [JsonProperty("ProtocolParams")]
        public ProtocolParams ProtocolParams{ get; set; }

        /// <summary>
        /// Single-instance multi-concurrency configuration. Supports only Web functions.
        /// </summary>
        [JsonProperty("InstanceConcurrencyConfig")]
        public InstanceConcurrencyConfig InstanceConcurrencyConfig{ get; set; }

        /// <summary>
        /// Whether the Dns caching capability is enabled. Supports only the EVENT function. Defaults to FALSE. TRUE to enable, FALSE to shutdown.
        /// </summary>
        [JsonProperty("DnsCache")]
        public string DnsCache{ get; set; }

        /// <summary>
        /// Private network access configuration
        /// </summary>
        [JsonProperty("IntranetConfig")]
        public IntranetConfigIn IntranetConfig{ get; set; }

        /// <summary>
        /// Ignorable system log reporting
        /// </summary>
        [JsonProperty("IgnoreSysLog")]
        public bool? IgnoreSysLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "Publish", this.Publish);
            this.SetParamSimple(map, prefix + "L5Enable", this.L5Enable);
            this.SetParamArrayObj(map, prefix + "Layers.", this.Layers);
            this.SetParamObj(map, prefix + "DeadLetterConfig.", this.DeadLetterConfig);
            this.SetParamObj(map, prefix + "PublicNetConfig.", this.PublicNetConfig);
            this.SetParamObj(map, prefix + "CfsConfig.", this.CfsConfig);
            this.SetParamSimple(map, prefix + "InitTimeout", this.InitTimeout);
            this.SetParamObj(map, prefix + "ProtocolParams.", this.ProtocolParams);
            this.SetParamObj(map, prefix + "InstanceConcurrencyConfig.", this.InstanceConcurrencyConfig);
            this.SetParamSimple(map, prefix + "DnsCache", this.DnsCache);
            this.SetParamObj(map, prefix + "IntranetConfig.", this.IntranetConfig);
            this.SetParamSimple(map, prefix + "IgnoreSysLog", this.IgnoreSysLog);
        }
    }
}

