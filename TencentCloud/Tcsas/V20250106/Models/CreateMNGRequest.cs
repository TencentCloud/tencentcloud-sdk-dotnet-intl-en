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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMNGRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Mini game type</p>
        /// </summary>
        [JsonProperty("MNPType")]
        public string MNPType{ get; set; }

        /// <summary>
        /// <p>Mini game name</p>
        /// </summary>
        [JsonProperty("MNPName")]
        public string MNPName{ get; set; }

        /// <summary>
        /// <p>Mini game icon</p>
        /// </summary>
        [JsonProperty("MNPIcon")]
        public string MNPIcon{ get; set; }

        /// <summary>
        /// <p>Mini game introduction</p>
        /// </summary>
        [JsonProperty("MNPIntro")]
        public string MNPIntro{ get; set; }

        /// <summary>
        /// <p>Mini game description</p>
        /// </summary>
        [JsonProperty("MNPDesc")]
        public string MNPDesc{ get; set; }

        /// <summary>
        /// <p>Platform ID</p>
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// <p>Team ID</p>
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MNPType", this.MNPType);
            this.SetParamSimple(map, prefix + "MNPName", this.MNPName);
            this.SetParamSimple(map, prefix + "MNPIcon", this.MNPIcon);
            this.SetParamSimple(map, prefix + "MNPIntro", this.MNPIntro);
            this.SetParamSimple(map, prefix + "MNPDesc", this.MNPDesc);
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
        }
    }
}

