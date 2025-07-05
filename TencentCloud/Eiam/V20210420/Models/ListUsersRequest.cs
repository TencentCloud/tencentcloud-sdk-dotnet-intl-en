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

namespace TencentCloud.Eiam.V20210420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListUsersRequest : AbstractModel
    {
        
        /// <summary>
        /// User attribute search criterion. The supported search criteria include username, mobile number, email address, user locking status, user freezing status, creation time, and last modification time, which can also be combined. In addition, multiple query methods such as full match, partial match, and range match are supported. Specifically, double quotation marks ("") indicate full match, an asterisk (*) at the end of the field indicates partial match, brackets separated by a comma ([Min,Max]) indicate query within a closed interval, braces separated by a comma ({Min,Max}) indicate query within an open interval, and a bracket and a brace can be used together (for example, {Min,Max] indicates that the minimum value is excluded and the maximum value is included in the query). Range query supports using an asterisk (for example, {20,*] indicates an interval including all data greater than 20) and querying by time period. The supported attributes include creation time (CreationTime) and last modification time (LastUpdateTime) in ISO 8601 format, such as `2021-01-13T09:44:07.182+0000`.
        /// </summary>
        [JsonProperty("SearchCondition")]
        public UserSearchCriteria SearchCondition{ get; set; }

        /// <summary>
        /// User attributes expected to be returned. All built-in user attributes will be returned by default, including user UUID (UserId), nickname (DisplayName), username (UserName), mobile number (Phone), email address (Email), status (Status), user group (SubjectGroups), organization path (OrgPath), remarks (Description), creation time (CreationTime), last modification time (LastUpdateTime), and last login time (LastLoginTime).
        /// </summary>
        [JsonProperty("ExpectedFields")]
        public string[] ExpectedFields{ get; set; }

        /// <summary>
        /// Set of sort criteria. The supported attributes for sorting include username (UserName), nickname (DisplayName), mobile number (Phone), email address (Email), user status (Status), creation time (CreatedDate), last modification time (LastUpdateTime), and last login time (LastLoginTime). If this field is left empty, the results will be sorted in alphabetical order by nickname (DisplayName).
        /// </summary>
        [JsonProperty("Sort")]
        public SortCondition Sort{ get; set; }

        /// <summary>
        /// Pagination offset. Default value: 0. The `Offset` and `Limit` fields need to be used together; otherwise, the query results will not be paginated, and up to 1,000 users will be returned.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results read per page. Default value: 50. Maximum value: 100. The `Offset` and `Limit` fields need to be used together; otherwise, the query results will not be paginated, and up to 1,000 users will be returned.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Whether to view the total number of search results. Default value: false (no).
        /// </summary>
        [JsonProperty("IncludeTotal")]
        public bool? IncludeTotal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SearchCondition.", this.SearchCondition);
            this.SetParamArraySimple(map, prefix + "ExpectedFields.", this.ExpectedFields);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "IncludeTotal", this.IncludeTotal);
        }
    }
}

