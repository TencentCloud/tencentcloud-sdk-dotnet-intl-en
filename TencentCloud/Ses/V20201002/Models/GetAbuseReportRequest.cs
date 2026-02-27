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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetAbuseReportRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Offset.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Limit quantity (default: 1000).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Sender domain name.
        /// </summary>
        [JsonProperty("FromDomain")]
        public string FromDomain{ get; set; }

        /// <summary>
        /// Sender address.
        /// </summary>
        [JsonProperty("FromAddress")]
        public string FromAddress{ get; set; }

        /// <summary>
        /// Recipient domain name.
        /// </summary>
        [JsonProperty("Mta")]
        public string Mta{ get; set; }

        /// <summary>
        /// Receive email.
        /// </summary>
        [JsonProperty("ToAddress")]
        public string ToAddress{ get; set; }

        /// <summary>
        /// Template ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FromDomain", this.FromDomain);
            this.SetParamSimple(map, prefix + "FromAddress", this.FromAddress);
            this.SetParamSimple(map, prefix + "Mta", this.Mta);
            this.SetParamSimple(map, prefix + "ToAddress", this.ToAddress);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

