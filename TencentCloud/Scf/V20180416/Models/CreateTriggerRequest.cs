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

    public class CreateTriggerRequest : AbstractModel
    {
        
        /// <summary>
        /// Function name bound to the created trigger
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Name of the trigger to create. If it is a scheduled trigger, the name supports English letters, digits, hyphens, and underscores, up to 100 characters. If it is a COS trigger, it must be the access domain of the corresponding COS storage bucket suitable for the XML API (for example, 5401-5ff414-12345.cos.ap-shanghai.myqcloud.com). For other triggers, see the parameter description of the specific trigger binding.
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// Trigger type. Currently supports cos, cls, timer, ckafka, and http types. To create a function URL, please use the http type. See [Creating a Function URL](https://www.tencentcloud.com/document/product/583/100227?from_cn_redirect=1#33bbbda4-9131-48a6-ac37-ac62ffe01424). To create a cls trigger, see CLS Creating Delivery SCF Task.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Parameters corresponding to the trigger. For details, see [Trigger Description](https://www.tencentcloud.com/document/product/583/39901?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("TriggerDesc")]
        public string TriggerDesc{ get; set; }

        /// <summary>
        /// Namespace of the function
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Version or alias that the trigger takes effect on. It is recommended to fill in $DEFAULT for future grayscale release. Default value: $LATEST.
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// Initial status of the trigger. OPEN means enabling, and CLOSE means disabling.
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// User-defined parameter. Only timer triggers are supported.
        /// </summary>
        [JsonProperty("CustomArgument")]
        public string CustomArgument{ get; set; }

        /// <summary>
        /// Trigger description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TriggerDesc", this.TriggerDesc);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "CustomArgument", this.CustomArgument);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

