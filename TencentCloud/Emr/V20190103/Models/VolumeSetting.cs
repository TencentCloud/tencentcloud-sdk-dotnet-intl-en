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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VolumeSetting : AbstractModel
    {
        
        /// <summary>
        /// Data volume type.
        /// <li>HOST_PATH indicates support for the local path.</li>
        /// <li>NEW_PVC indicates creating a PVC.</li>
        /// For the data volume types supported by component roles, see the EMR on TKE cluster deployment instructions: [Deployment Instructions](https://www.tencentcloud.com/document/product/589/94254?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("VolumeType")]
        public string VolumeType{ get; set; }

        /// <summary>
        /// Host path information.
        /// </summary>
        [JsonProperty("HostPath")]
        public HostPathVolumeSource HostPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VolumeType", this.VolumeType);
            this.SetParamObj(map, prefix + "HostPath.", this.HostPath);
        }
    }
}

