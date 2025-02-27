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
        /// Sub-Account uin.
        /// </summary>
        [JsonProperty("CustomerUin")]
        public string CustomerUin{ get; set; }

        /// <summary>
        /// Contact email.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Contact phone number.
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Mark")]
        public string Mark{ get; set; }

        /// <summary>
        /// Display name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Binding time.
        /// </summary>
        [JsonProperty("BindTime")]
        public string BindTime{ get; set; }

        /// <summary>
        /// Account status
        /// .
        /// 0: normal.
        /// 1: forcibly mandatory (this function is not supported yet).
        /// 2: mandatory arrears. 
        /// </summary>
        [JsonProperty("AccountStatus")]
        public string AccountStatus{ get; set; }

        /// <summary>
        /// Identity verification status.
        /// -1: files not uploaded.
        /// 0: not submitted for review.
        /// 1: under review.
        /// 2: review error.
        /// 3: approved.
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

