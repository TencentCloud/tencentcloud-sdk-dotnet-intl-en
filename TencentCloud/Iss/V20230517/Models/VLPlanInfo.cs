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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VLPlanInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Plan ID</p>
        /// </summary>
        [JsonProperty("VLPlanId")]
        public string VLPlanId{ get; set; }

        /// <summary>
        /// <p>Plan name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Plan description.</p>
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// <p>ID of the visual understanding template</p>
        /// </summary>
        [JsonProperty("VLTemplateId")]
        public string VLTemplateId{ get; set; }

        /// <summary>
        /// <p>Callback notification configuration</p>
        /// </summary>
        [JsonProperty("Callback")]
        public CallbackURL Callback{ get; set; }

        /// <summary>
        /// <p>File expiration time (seconds)</p>
        /// </summary>
        [JsonProperty("FileExpires")]
        public long? FileExpires{ get; set; }

        /// <summary>
        /// <p>Number of channels included in the plan</p>
        /// </summary>
        [JsonProperty("ChannelCount")]
        public long? ChannelCount{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>Last update time</p>
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VLPlanId", this.VLPlanId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "VLTemplateId", this.VLTemplateId);
            this.SetParamObj(map, prefix + "Callback.", this.Callback);
            this.SetParamSimple(map, prefix + "FileExpires", this.FileExpires);
            this.SetParamSimple(map, prefix + "ChannelCount", this.ChannelCount);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
        }
    }
}

