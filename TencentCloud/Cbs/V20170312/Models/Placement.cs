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
        /// ID of the project to which the instance belongs. This parameter can be obtained from the projectId field in the returned values of [DescribeProject](https://intl.cloud.tencent.com/document/api/378/4400?from_cn_redirect=1). If this is left empty, default project is used.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// ID of dedicated cluster which the instance belongs to. When it is an input parameter, the specified CdcId dedicated cluster resource is operated, and it can be left blank. When it is an output parameter, it is the ID of the dedicated cluster which the resource belongs to, and it can be left blank.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// Cage ID. When it is an input parameter, the specified CageID resource is operated, and it can be left blank. When it is an output parameter, it is the ID of the cage the resource belongs to, and it can be left blank.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CageId")]
        public string CageId{ get; set; }

        /// <summary>
        /// Dedicated cluster name. When it is an input parameter, it is ignored.  When it is an output parameter, it is the name of the dedicated cluster the cloud disk belongs to, and it can be left blank.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CdcName")]
        public string CdcName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "CageId", this.CageId);
            this.SetParamSimple(map, prefix + "CdcName", this.CdcName);
        }
    }
}

