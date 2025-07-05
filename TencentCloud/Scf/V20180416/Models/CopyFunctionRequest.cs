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

    public class CopyFunctionRequest : AbstractModel
    {
        
        /// <summary>
        /// Name of the function to be replicated
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Name of the new function
        /// </summary>
        [JsonProperty("NewFunctionName")]
        public string NewFunctionName{ get; set; }

        /// <summary>
        /// Namespace of the function to be replicated. The default value is `default`.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Namespace of the replicated function. The default value is default.
        /// </summary>
        [JsonProperty("TargetNamespace")]
        public string TargetNamespace{ get; set; }

        /// <summary>
        /// Description of the new function
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Region of the target of the function replication. If the value is not set, the current region is used by default.
        /// </summary>
        [JsonProperty("TargetRegion")]
        public string TargetRegion{ get; set; }

        /// <summary>
        /// It specifies whether to replace the function with the same name in the target namespace. The default option is `FALSE`.
        /// (Note: The `TRUE` option results in deletion of the function in the target namespace. Please operate with caution.)
        /// TRUE: Replaces the function.
        /// FALSE: Does not replace the function.
        /// </summary>
        [JsonProperty("Override")]
        public bool? Override{ get; set; }

        /// <summary>
        /// It specifies whether to replicate the function attributes, including environment variables, memory, timeout, function description, labels, and VPC. The default value is `TRUE`.
        /// TRUE: Replicates the function configuration.
        /// FALSE: Does not replicate the function configuration.
        /// </summary>
        [JsonProperty("CopyConfiguration")]
        public bool? CopyConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "NewFunctionName", this.NewFunctionName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "TargetNamespace", this.TargetNamespace);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TargetRegion", this.TargetRegion);
            this.SetParamSimple(map, prefix + "Override", this.Override);
            this.SetParamSimple(map, prefix + "CopyConfiguration", this.CopyConfiguration);
        }
    }
}

