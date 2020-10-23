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

    public class CreateTriggerRequest : AbstractModel
    {
        
        /// <summary>
        /// Name of the function bound to the new trigger
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Name of a new trigger. For a timer trigger, the name can contain up to 100 letters, digits, dashes, and underscores; for a COS trigger, it should be an access domain name of the corresponding COS bucket applicable to the XML API (e.g., 5401-5ff414-12345.cos.ap-shanghai.myqcloud.com); for other triggers, please see the descriptions of parameters bound to the specific trigger.
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// Trigger type. Currently, COS, CMQ, timer, and ckafka triggers are supported.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// For parameters of triggers, see [Trigger Description](https://intl.cloud.tencent.com/document/product/583/39901?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("TriggerDesc")]
        public string TriggerDesc{ get; set; }

        /// <summary>
        /// Function namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Function version
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// Initial enabling status of the trigger. `OPEN` indicates enabled, and `CLOSE` indicates disabled.
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// Custom argument, supporting only the timer trigger.
        /// </summary>
        [JsonProperty("CustomArgument")]
        public string CustomArgument{ get; set; }


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
        }
    }
}

