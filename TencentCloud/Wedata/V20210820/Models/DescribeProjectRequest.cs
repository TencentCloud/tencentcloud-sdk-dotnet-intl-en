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

    public class DescribeProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID. It is common to use the Project ID for queries, and either this or projectName must be present.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Whether to Display Associated Cluster Information
        /// </summary>
        [JsonProperty("DescribeClusters")]
        public bool? DescribeClusters{ get; set; }

        /// <summary>
        /// Whether to Display Information of Associated Execution Group, only partial information.
        /// </summary>
        [JsonProperty("DescribeExecutors")]
        public bool? DescribeExecutors{ get; set; }

        /// <summary>
        /// Default not to display project administrator information
        /// </summary>
        [JsonProperty("DescribeAdminUsers")]
        public bool? DescribeAdminUsers{ get; set; }

        /// <summary>
        /// Default not to count the number of project personnel
        /// </summary>
        [JsonProperty("DescribeMemberCount")]
        public bool? DescribeMemberCount{ get; set; }

        /// <summary>
        /// Default not to query creator's information
        /// </summary>
        [JsonProperty("DescribeCreator")]
        public bool? DescribeCreator{ get; set; }

        /// <summary>
        /// The project name is unique within a tenant, generally used for conversion to Project ID.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DescribeClusters", this.DescribeClusters);
            this.SetParamSimple(map, prefix + "DescribeExecutors", this.DescribeExecutors);
            this.SetParamSimple(map, prefix + "DescribeAdminUsers", this.DescribeAdminUsers);
            this.SetParamSimple(map, prefix + "DescribeMemberCount", this.DescribeMemberCount);
            this.SetParamSimple(map, prefix + "DescribeCreator", this.DescribeCreator);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
        }
    }
}

