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

    public class LinkAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// User directory ID
        /// </summary>
        [JsonProperty("UserStoreId")]
        public string UserStoreId{ get; set; }

        /// <summary>
        /// Primary user ID
        /// </summary>
        [JsonProperty("PrimaryUserId")]
        public string PrimaryUserId{ get; set; }

        /// <summary>
        /// Secondary user ID
        /// </summary>
        [JsonProperty("SecondaryUserId")]
        public string SecondaryUserId{ get; set; }

        /// <summary>
        /// Fusion attribute
        /// 
        /// <li> **PHONENUMBER** </li>	  Mobile number
        /// <li> **EMAIL** </li>  Email
        /// </summary>
        [JsonProperty("UserLinkedOnAttribute")]
        public string UserLinkedOnAttribute{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserStoreId", this.UserStoreId);
            this.SetParamSimple(map, prefix + "PrimaryUserId", this.PrimaryUserId);
            this.SetParamSimple(map, prefix + "SecondaryUserId", this.SecondaryUserId);
            this.SetParamSimple(map, prefix + "UserLinkedOnAttribute", this.UserLinkedOnAttribute);
        }
    }
}

