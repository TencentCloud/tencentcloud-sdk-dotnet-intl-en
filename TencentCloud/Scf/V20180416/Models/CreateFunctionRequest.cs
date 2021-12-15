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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFunctionRequest : AbstractModel
    {
        
        /// <summary>
        /// Name of the new function. The name can contain 2 to 60 characters, including English letters, digits, hyphens (-), and underscores (_). The name must start with a letter and cannot end with a hyphen or underscore.
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Function code. Note: `COS`, `ZipFile`, and `DemoId` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("Code")]
        public Code Code{ get; set; }

        /// <summary>
        /// Function handler name. It supports the format of "file name.handler name" where the file name and handler name are separated with a "." (for Java, it is in the format of "package name.class name::handler name"). File and handler names can contain 2–60 letters, digits, underscores, and dashes and must start and end with letters
        /// </summary>
        [JsonProperty("Handler")]
        public string Handler{ get; set; }

        /// <summary>
        /// Function description. It can contain up to 1,000 characters including letters, digits, spaces, commas (,), periods (.), and Chinese characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Memory size available for function during execution. Default value: 128 MB. Value range: 64 or 128-3072 MB in increments of 128 MB
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// Maximum execution duration of function in seconds. Value range: 1-900 seconds. Default value: 3 seconds
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// Function environment variable
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment{ get; set; }

        /// <summary>
        /// Function runtime environment. Valid values: Python2.7, Python3.6, Nodejs6.10, Nodejs8.9, Nodejs10.15, Nodejs12.16, Php5, Php7, Go1, Java8, CustomRuntime. Default value: Python2.7
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// Function VPC configuration
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// Function namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Role bound to the function
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// Specifies whether to [install dependency online](https://intl.cloud.tencent.com/document/product/583/37920?from_cn_redirect=1). `TRUE`: yes. Default to `FALSE`. It is only available for Node.js functions.
        /// </summary>
        [JsonProperty("InstallDependency")]
        public string InstallDependency{ get; set; }

        /// <summary>
        /// CLS Logset ID to which the function logs are shipped
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// CLS Topic ID to which the function logs are shipped
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// Function type. The default value is `Event`. Enter `Event` if you need to create a trigger function. Enter `HTTP` if you need to create an HTTP function service.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Code source. Valid values: ZipFile, Cos, Demo
        /// </summary>
        [JsonProperty("CodeSource")]
        public string CodeSource{ get; set; }

        /// <summary>
        /// List of layer versions to be associate with the function. Layers will be overwritten sequentially in the order in the list.
        /// </summary>
        [JsonProperty("Layers")]
        public LayerVersionSimple[] Layers{ get; set; }

        /// <summary>
        /// Dead letter queue parameter
        /// </summary>
        [JsonProperty("DeadLetterConfig")]
        public DeadLetterConfig DeadLetterConfig{ get; set; }

        /// <summary>
        /// Public network access configuration
        /// </summary>
        [JsonProperty("PublicNetConfig")]
        public PublicNetConfigIn PublicNetConfig{ get; set; }

        /// <summary>
        /// File system configuration parameter, which is used for the function to mount the file system
        /// </summary>
        [JsonProperty("CfsConfig")]
        public CfsConfig CfsConfig{ get; set; }

        /// <summary>
        /// The function initialization timeout period. It defaults to 65s for general cases and 90s for image deployment functions.
        /// </summary>
        [JsonProperty("InitTimeout")]
        public long? InitTimeout{ get; set; }

        /// <summary>
        /// Tag parameter of the function. It is an array of key-value pairs.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Whether to enable the async attribute. TRUE: yes; FALSE: no
        /// </summary>
        [JsonProperty("AsyncRunEnable")]
        public string AsyncRunEnable{ get; set; }

        /// <summary>
        /// Whether to enable event tracking. TRUE: yes; FALSE: no
        /// </summary>
        [JsonProperty("TraceEnable")]
        public string TraceEnable{ get; set; }

        /// <summary>
        /// Protocols supported by HTTP-triggered functions. Valid value: `WS` (WebSockets)
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }

        /// <summary>
        /// Parameters of the specified protocol
        /// </summary>
        [JsonProperty("ProtocolParams")]
        public ProtocolParams ProtocolParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamObj(map, prefix + "Code.", this.Code);
            this.SetParamSimple(map, prefix + "Handler", this.Handler);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CodeSource", this.CodeSource);
            this.SetParamArrayObj(map, prefix + "Layers.", this.Layers);
            this.SetParamObj(map, prefix + "DeadLetterConfig.", this.DeadLetterConfig);
            this.SetParamObj(map, prefix + "PublicNetConfig.", this.PublicNetConfig);
            this.SetParamObj(map, prefix + "CfsConfig.", this.CfsConfig);
            this.SetParamSimple(map, prefix + "InitTimeout", this.InitTimeout);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AsyncRunEnable", this.AsyncRunEnable);
            this.SetParamSimple(map, prefix + "TraceEnable", this.TraceEnable);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamObj(map, prefix + "ProtocolParams.", this.ProtocolParams);
        }
    }
}

