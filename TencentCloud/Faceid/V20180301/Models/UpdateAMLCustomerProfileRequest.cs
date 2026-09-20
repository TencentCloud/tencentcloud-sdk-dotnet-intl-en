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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAMLCustomerProfileRequest : AbstractModel
    {
        
        /// <summary>
        /// End user's unique identifier in the customer system, up to 256 characters.
        /// </summary>
        [JsonProperty("UniqueCustomerID")]
        public string UniqueCustomerID{ get; set; }

        /// <summary>
        /// Entity type. Enumeration values: PERSON (individual) / COMPANY (company).
        /// </summary>
        [JsonProperty("EntityType")]
        public string EntityType{ get; set; }

        /// <summary>
        /// Personal information, required when EntityType=PERSON. 
        /// Input restriction: EntityType=PERSON.
        /// </summary>
        [JsonProperty("Person")]
        public Person Person{ get; set; }

        /// <summary>
        /// Enterprise information, required when EntityType=COMPANY. Input restriction: EntityType=COMPANY.
        /// </summary>
        [JsonProperty("Company")]
        public Company Company{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UniqueCustomerID", this.UniqueCustomerID);
            this.SetParamSimple(map, prefix + "EntityType", this.EntityType);
            this.SetParamObj(map, prefix + "Person.", this.Person);
            this.SetParamObj(map, prefix + "Company.", this.Company);
        }
    }
}

