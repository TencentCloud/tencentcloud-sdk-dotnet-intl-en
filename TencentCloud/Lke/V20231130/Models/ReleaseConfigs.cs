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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReleaseConfigs : AbstractModel
    {
        
        /// <summary>
        /// Configuration item description.
        /// </summary>
        [JsonProperty("ConfigItem")]
        public string ConfigItem{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty("Action")]
        public ulong? Action{ get; set; }

        /// <summary>
        /// Content after modification.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Content before modification.
        /// </summary>
        [JsonProperty("LastValue")]
        public string LastValue{ get; set; }

        /// <summary>
        /// Modified content (display "content" with priority. If "content" is empty, take "value").
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Reason for failure.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigItem", this.ConfigItem);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "LastValue", this.LastValue);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

