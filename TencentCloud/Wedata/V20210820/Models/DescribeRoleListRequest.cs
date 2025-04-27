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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRoleListRequest : AbstractModel
    {
        
        /// <summary>
        /// Return all Roles
        /// </summary>
        [JsonProperty("ShowAllRoles")]
        public bool? ShowAllRoles{ get; set; }

        /// <summary>
        /// Role type (system, tenant, project) that needs to be returned
        /// </summary>
        [JsonProperty("IncludeRoleTypes")]
        public string[] IncludeRoleTypes{ get; set; }

        /// <summary>
        /// Specifies the statistics of role binding personnel. Only supported in the private edition.
        /// </summary>
        [JsonProperty("DescribeMemberCount")]
        public bool? DescribeMemberCount{ get; set; }

        /// <summary>
        /// Specifies the operator information. describes the privatized multi-tenancy version.
        /// </summary>
        [JsonProperty("DescribeOperator")]
        public bool? DescribeOperator{ get; set; }

        /// <summary>
        /// System Role
        /// </summary>
        [JsonProperty("DescribeSystemRoleOnly")]
        public bool? DescribeSystemRoleOnly{ get; set; }

        /// <summary>
        /// Custom Role
        /// </summary>
        [JsonProperty("DescribeCustomRoleOnly")]
        public bool? DescribeCustomRoleOnly{ get; set; }

        /// <summary>
        /// Permission to view
        /// </summary>
        [JsonProperty("DescribePrivileges")]
        public bool? DescribePrivileges{ get; set; }

        /// <summary>
        /// Filter criteria for Role ID
        /// </summary>
        [JsonProperty("RoleIds")]
        public string[] RoleIds{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Page number
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// Paging information
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Query Field
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Sorting Field
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderFields[] OrderFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShowAllRoles", this.ShowAllRoles);
            this.SetParamArraySimple(map, prefix + "IncludeRoleTypes.", this.IncludeRoleTypes);
            this.SetParamSimple(map, prefix + "DescribeMemberCount", this.DescribeMemberCount);
            this.SetParamSimple(map, prefix + "DescribeOperator", this.DescribeOperator);
            this.SetParamSimple(map, prefix + "DescribeSystemRoleOnly", this.DescribeSystemRoleOnly);
            this.SetParamSimple(map, prefix + "DescribeCustomRoleOnly", this.DescribeCustomRoleOnly);
            this.SetParamSimple(map, prefix + "DescribePrivileges", this.DescribePrivileges);
            this.SetParamArraySimple(map, prefix + "RoleIds.", this.RoleIds);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
        }
    }
}

