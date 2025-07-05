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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntlTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// The registrant contact.
        /// </summary>
        [JsonProperty("RegistrantContact")]
        public RegistrantContact RegistrantContact{ get; set; }

        /// <summary>
        /// The admin contact.
        /// </summary>
        [JsonProperty("AdminContact")]
        public AdminContact AdminContact{ get; set; }

        /// <summary>
        /// The technical contact.
        /// </summary>
        [JsonProperty("TechnicalContact")]
        public TechnicalContact TechnicalContact{ get; set; }

        /// <summary>
        /// The contact person for bills.
        /// </summary>
        [JsonProperty("BillingContact")]
        public BillingContact BillingContact{ get; set; }

        /// <summary>
        /// The creation time.
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// The profile ID.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// The registrant type. Valid values: `I` (individual), `E` (organization).
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// The last updated time.
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// The account ID.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Whether the profile is the default one.
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RegistrantContact.", this.RegistrantContact);
            this.SetParamObj(map, prefix + "AdminContact.", this.AdminContact);
            this.SetParamObj(map, prefix + "TechnicalContact.", this.TechnicalContact);
            this.SetParamObj(map, prefix + "BillingContact.", this.BillingContact);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
        }
    }
}

