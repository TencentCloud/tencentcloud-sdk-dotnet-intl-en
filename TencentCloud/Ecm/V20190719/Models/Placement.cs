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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Placement : AbstractModel
    {
        
        /// <summary>
        /// [AZ ID](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#ZoneInfo) of the cloud disk, which can be obtained from the `Zone` field in the returned value of the [DescribeZones](https://intl.cloud.tencent.com/document/product/213/15707?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Cage ID. When it is used as an input parameter, it indicates to manipulate the resources in the cage with the specified `CageId` and can be left empty. When it is used as an output parameter, it represents the cage ID of the resource and can be left empty.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CageId")]
        public string CageId{ get; set; }

        /// <summary>
        /// Project ID of the instance, which can be obtained from the `projectId` field in the returned value of the [DescribeProject](https://intl.cloud.tencent.com/document/api/378/4400?from_cn_redirect=1) API. If this parameter is not specified, the default project ID will be used.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Name of the dedicated cluster. When it is used as an input parameter, it is ignored. When it is used as an output parameter, it represents the name of the dedicated cluster to which the cloud disk belongs, and it can be left empty.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CdcName")]
        public string CdcName{ get; set; }

        /// <summary>
        /// Dedicated cluster ID of the instance. When it is used as an input parameter, it indicates to manipulate the resources in the dedicated cluster with the specified `CdcId` and can be left empty. When it is used as an output parameter, it represents the dedicated cluster ID of the resource and can be left empty.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CageId", this.CageId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CdcName", this.CdcName);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
        }
    }
}

