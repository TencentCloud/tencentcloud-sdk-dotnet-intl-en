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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KBDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>KB patch internal ID (kb_info.id)</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>KB No.<br>Parameter format: e.g. KB5001234</p>
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// <p>KB patch name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Reference link (Microsoft Official Documentation address)</p>
        /// </summary>
        [JsonProperty("ReferUrl")]
        public string ReferUrl{ get; set; }

        /// <summary>
        /// <p>Release time<br>Parameter format: YYYY-MM-DD HH:mm:ss</p>
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// <p>Whether restart is required after installing this KB<br>Enumeration values:<br>true: required<br>false: not required</p>
        /// </summary>
        [JsonProperty("NeedRestart")]
        public bool? NeedRestart{ get; set; }

        /// <summary>
        /// <p>Associated vulnerability list</p>
        /// </summary>
        [JsonProperty("RelateVulList")]
        public VulBriefInfo[] RelateVulList{ get; set; }

        /// <summary>
        /// <p>Total number of associated vulnerabilities</p>
        /// </summary>
        [JsonProperty("RelateVulCount")]
        public long? RelateVulCount{ get; set; }

        /// <summary>
        /// <p>Associated os version</p>
        /// </summary>
        [JsonProperty("RelateProduct")]
        public string RelateProduct{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ReferUrl", this.ReferUrl);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamArrayObj(map, prefix + "RelateVulList.", this.RelateVulList);
            this.SetParamSimple(map, prefix + "RelateVulCount", this.RelateVulCount);
            this.SetParamSimple(map, prefix + "RelateProduct", this.RelateProduct);
        }
    }
}

