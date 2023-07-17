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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCustomerInfoData : AbstractModel
    {
        
        /// <summary>
        /// Customer UIN Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomerUin")]
        public string CustomerUin{ get; set; }

        /// <summary>
        /// Email Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Mobile number Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// Remarks Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Mark")]
        public string Mark{ get; set; }

        /// <summary>
        /// Displayed name Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Binding time Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BindTime")]
        public string BindTime{ get; set; }

        /// <summary>
        /// Account status Valid values: `0` (Not frozen),  `1` (Frozen).  Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccountStatus")]
        public string AccountStatus{ get; set; }

        /// <summary>
        /// Identity verification status Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthStatus")]
        public string AuthStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerUin", this.CustomerUin);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Mark", this.Mark);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "BindTime", this.BindTime);
            this.SetParamSimple(map, prefix + "AccountStatus", this.AccountStatus);
            this.SetParamSimple(map, prefix + "AuthStatus", this.AuthStatus);
        }
    }
}

