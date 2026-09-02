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

    public class UebaUserSummary : AbstractModel
    {
        
        /// <summary>
        /// Quantity of all users
        /// </summary>
        [JsonProperty("AllUserCount")]
        public ulong? AllUserCount{ get; set; }

        /// <summary>
        /// Number of abnormal users
        /// </summary>
        [JsonProperty("AbnormalUserCount")]
        public ulong? AbnormalUserCount{ get; set; }

        /// <summary>
        /// Number of users for the cloud account
        /// </summary>
        [JsonProperty("UserCount")]
        public ulong? UserCount{ get; set; }

        /// <summary>
        /// Number of sub-users
        /// </summary>
        [JsonProperty("SubUserCount")]
        public ulong? SubUserCount{ get; set; }

        /// <summary>
        /// Number of custom users
        /// </summary>
        [JsonProperty("CustomUserCount")]
        public ulong? CustomUserCount{ get; set; }

        /// <summary>
        /// Custom user sum building block
        /// </summary>
        [JsonProperty("Element")]
        public UebaUserSummaryElement[] Element{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllUserCount", this.AllUserCount);
            this.SetParamSimple(map, prefix + "AbnormalUserCount", this.AbnormalUserCount);
            this.SetParamSimple(map, prefix + "UserCount", this.UserCount);
            this.SetParamSimple(map, prefix + "SubUserCount", this.SubUserCount);
            this.SetParamSimple(map, prefix + "CustomUserCount", this.CustomUserCount);
            this.SetParamArrayObj(map, prefix + "Element.", this.Element);
        }
    }
}

