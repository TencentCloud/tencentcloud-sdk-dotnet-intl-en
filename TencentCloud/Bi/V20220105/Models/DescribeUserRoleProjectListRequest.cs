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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserRoleProjectListRequest : AbstractModel
    {
        
        /// <summary>
        /// Page number.
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// Number of pages.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Whether to only obtain users bound to the WeCom app.
        /// </summary>
        [JsonProperty("IsOnlyBindAppUser")]
        public bool? IsOnlyBindAppUser{ get; set; }

        /// <summary>
        /// Whether to obtain all the data.
        /// </summary>
        [JsonProperty("AllPage")]
        public bool? AllPage{ get; set; }

        /// <summary>
        /// Role code.
        /// </summary>
        [JsonProperty("RoleCode")]
        public string RoleCode{ get; set; }

        /// <summary>
        /// User ID list.
        /// </summary>
        [JsonProperty("UserIdList")]
        public string[] UserIdList{ get; set; }

        /// <summary>
        /// Search keywords.
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "IsOnlyBindAppUser", this.IsOnlyBindAppUser);
            this.SetParamSimple(map, prefix + "AllPage", this.AllPage);
            this.SetParamSimple(map, prefix + "RoleCode", this.RoleCode);
            this.SetParamArraySimple(map, prefix + "UserIdList.", this.UserIdList);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
        }
    }
}

