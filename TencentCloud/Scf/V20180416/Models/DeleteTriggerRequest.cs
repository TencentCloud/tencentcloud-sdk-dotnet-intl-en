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

    public class DeleteTriggerRequest : AbstractModel
    {
        
        /// <summary>
        /// Function name
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Trigger name to delete
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// Trigger type to delete. Currently only `timer`, `ckafka`, `apigw`, `cls`, `cos`, `cmq`, and `http` are supported.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Namespace of the function
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// If the trigger type to delete is COS trigger, this field must be specified, storing data in JSON format {"event":"cos:ObjectCreated:*"}. The data content is in the same format as this field in the SetTrigger API. If the trigger type to delete is scheduled trigger or CMQ trigger, this field can be unspecified.
        /// </summary>
        [JsonProperty("TriggerDesc")]
        public string TriggerDesc{ get; set; }

        /// <summary>
        /// The version or alias that the trigger to be deleted actually points to. Default value: $LATEST.
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "TriggerDesc", this.TriggerDesc);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
        }
    }
}

