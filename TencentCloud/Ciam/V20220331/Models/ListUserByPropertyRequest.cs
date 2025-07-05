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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListUserByPropertyRequest : AbstractModel
    {
        
        /// <summary>
        /// User directory ID
        /// </summary>
        [JsonProperty("UserStoreId")]
        public string UserStoreId{ get; set; }

        /// <summary>
        /// Query attribute
        /// 
        /// <li> **phoneNumber** </li>	  Mobile number
        /// <li> **email** </li>  Email
        /// </summary>
        [JsonProperty("PropertyCode")]
        public string PropertyCode{ get; set; }

        /// <summary>
        /// Attribute value
        /// </summary>
        [JsonProperty("PropertyValue")]
        public string PropertyValue{ get; set; }

        /// <summary>
        /// Whether the content is passed through
        /// </summary>
        [JsonProperty("Original")]
        public bool? Original{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserStoreId", this.UserStoreId);
            this.SetParamSimple(map, prefix + "PropertyCode", this.PropertyCode);
            this.SetParamSimple(map, prefix + "PropertyValue", this.PropertyValue);
            this.SetParamSimple(map, prefix + "Original", this.Original);
        }
    }
}

