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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// Space ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Identity ID for the CAM user synchronization. Valid values: When the PrincipalType value is Group, it is the CIC user group ID (g-********). When the PrincipalType value is User, it is the CIC user ID (u-********).
        /// </summary>
        [JsonProperty("PrincipalId")]
        public string PrincipalId{ get; set; }

        /// <summary>
        /// Token for querying the next page of returned results. During use of the API for the first time, NextToken is not needed. When you call the API for the first time, if the total number of returned data entries exceeds the MaxResults limit, the data is truncated and only MaxResults data entries are returned. Meanwhile, the return parameter IsTruncated is true and a NextToken is returned. You can use the NextToken returned last time to continue calling the API with other request parameters unchanged, to query the truncated data. You can use this method for multiple queries until IsTruncated is false, indicating that all data has been queried.
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// Maximum number of data entries per page. Value range: 1-100. Default value: 10.
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// Identity type for the CAM user synchronization. Valid values: User: indicates that the identity for the CAM user synchronization is a CIC user; Group: indicates that the identity for the CAM user synchronization is a CIC user group.
        /// </summary>
        [JsonProperty("PrincipalType")]
        public string PrincipalType{ get; set; }

        /// <summary>
        /// UIN of the synchronized target account of the Tencent Cloud Organization.
        /// </summary>
        [JsonProperty("TargetUin")]
        public long? TargetUin{ get; set; }

        /// <summary>
        /// Type of the synchronized target account of the Tencent Cloud Organization. ManagerUin: admin account; MemberUin: member account.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Permission configuration ID.
        /// </summary>
        [JsonProperty("RoleConfigurationId")]
        public string RoleConfigurationId{ get; set; }

        /// <summary>
        /// InProgress: The task is being executed; Success: The task execution succeeded; Failed: The task execution failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Task type.
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "PrincipalId", this.PrincipalId);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "PrincipalType", this.PrincipalType);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "RoleConfigurationId", this.RoleConfigurationId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
        }
    }
}
