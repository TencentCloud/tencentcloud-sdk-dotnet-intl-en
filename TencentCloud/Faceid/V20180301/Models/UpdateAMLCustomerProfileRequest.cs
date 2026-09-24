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
        /// <p>User's unique identifier in the customer system, up to 256 characters.</p>
        /// </summary>
        [JsonProperty("UniqueCustomerID")]
        public string UniqueCustomerID{ get; set; }

        /// <summary>
        /// <p>Entity type. Enumeration values: PERSON / COMPANY</p><p>Enumeration values:</p><ul><li>PERSON: individual</li><li>COMPANY: company</li></ul>
        /// </summary>
        [JsonProperty("EntityType")]
        public string EntityType{ get; set; }

        /// <summary>
        /// <p>Personal information, required when EntityType=PERSON</p><p>Input limit: EntityType=PERSON</p>
        /// </summary>
        [JsonProperty("Person")]
        public Person Person{ get; set; }

        /// <summary>
        /// <p>Enterprise info. Required when EntityType=COMPANY</p><p>Input limitation: EntityType=COMPANY</p>
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

