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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PodVolume : AbstractModel
    {
        
        /// <summary>
        /// Storage type. Valid values: `pvc` and `hostpath`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VolumeType")]
        public string VolumeType{ get; set; }

        /// <summary>
        /// This field will take effect if `VolumeType` is `pvc`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PVCVolume")]
        public PersistentVolumeContext PVCVolume{ get; set; }

        /// <summary>
        /// This field will take effect if `VolumeType` is `hostpath`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostVolume")]
        public HostVolumeContext HostVolume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VolumeType", this.VolumeType);
            this.SetParamObj(map, prefix + "PVCVolume.", this.PVCVolume);
            this.SetParamObj(map, prefix + "HostVolume.", this.HostVolume);
        }
    }
}

