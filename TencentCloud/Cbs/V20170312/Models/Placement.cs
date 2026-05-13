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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Placement : AbstractModel
    {
        
        /// <summary>
        /// The ID of the [Availability Zone](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#ZoneInfo) to which the cloud disk belongs. This parameter can be obtained from the Zone field in the returned values of [DescribeZones](https://intl.cloud.tencent.com/document/product/213/15707?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// CageId, which can be obtained via [DescribeDiskStoragePool](https://www.tencentcloud.com/document/api/362/62143?from_cn_redirect=1). as an input parameter, it operates on resources of the specified cage Id and can be empty. as an output parameter, it indicates the cage Id to which the resource belongs and can be empty.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CageId")]
        public string CageId{ get; set; }

        /// <summary>
        /// Instance'S project ID, which can be obtained by DescribeProject. by default if left blank, it is 0, indicating the default project.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Project to which instance belongs. search via [DescribeProject](https://www.tencentcloud.com/document/api/651/78725?from_cn_redirect=1).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Dedicated cluster name. When it is an input parameter, it is ignored.  When it is an output parameter, it is the name of the dedicated cluster the cloud disk belongs to, and it can be left blank.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CdcName")]
        public string CdcName{ get; set; }

        /// <summary>
        /// The exclusive cluster ID of the instance. can be obtained via [DescribeDiskStoragePool](https://www.tencentcloud.com/document/api/362/62143?from_cn_redirect=1). as an input parameter, it indicates operations on resources belonging to the designated CdcId exclusive cluster and can be empty. as an output parameter, it indicates the exclusive cluster ID of the resource and can be empty.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// Dedicated cluster ID
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CageId", this.CageId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "CdcName", this.CdcName);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
        }
    }
}

