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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeManagersRequest : AbstractModel
    {
        
        /// <summary>
        /// Company ID, obtain through the API DescribeCompanies
        /// </summary>
        [JsonProperty("CompanyId")]
        public long? CompanyId{ get; set; }

        /// <summary>
        /// Pagination offset. If not provided, default value is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Pagination quantity per page. If not provided, the default value is 10. Maximum value is 1000.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Manager name (deprecated). Please use SearchKey.
        /// </summary>
        [JsonProperty("ManagerName")]
        public string ManagerName{ get; set; }

        /// <summary>
        /// Fuzzy query manager mailbox (deprecated), please use SearchKey
        /// </summary>
        [JsonProperty("ManagerMail")]
        public string ManagerMail{ get; set; }

        /// <summary>
        /// Filter based on manager status. Valid values:
        /// 'none' pending review
        /// 'audit', reviewing by AsiaInfo
        /// 'CAaudit' CA under review
        /// 'ok' reviewed
        /// 'review failed' for 'invalid'
        /// expiring soon
        /// expired
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Based on the format: manager surname|manager name|mailbox|department, perform accurate matching
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ManagerName", this.ManagerName);
            this.SetParamSimple(map, prefix + "ManagerMail", this.ManagerMail);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
        }
    }
}

