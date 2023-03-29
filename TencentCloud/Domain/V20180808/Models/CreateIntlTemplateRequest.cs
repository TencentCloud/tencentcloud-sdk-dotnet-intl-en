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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateIntlTemplateRequest : AbstractModel
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
        /// The profile type. Valid values: `I` (individual, default), `E` (organization).
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RegistrantContact.", this.RegistrantContact);
            this.SetParamObj(map, prefix + "AdminContact.", this.AdminContact);
            this.SetParamObj(map, prefix + "TechnicalContact.", this.TechnicalContact);
            this.SetParamObj(map, prefix + "BillingContact.", this.BillingContact);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
        }
    }
}

