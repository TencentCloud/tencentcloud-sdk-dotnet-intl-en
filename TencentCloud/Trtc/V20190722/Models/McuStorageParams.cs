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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McuStorageParams : AbstractModel
    {
        
        /// <summary>
        /// Account information for third-party cloud storage (special note: if you select storage to cloud object storage (COS), there will be a charge for shipping recorded files to COS. for details, see cloud recording pricing information. storing to VOD will incur no charge for this item.).
        /// </summary>
        [JsonProperty("CloudStorage")]
        public CloudStorage CloudStorage{ get; set; }

        /// <summary>
        /// Account information of tencent cloud vod.
        /// </summary>
        [JsonProperty("McuCloudVod")]
        public McuCloudVod McuCloudVod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CloudStorage.", this.CloudStorage);
            this.SetParamObj(map, prefix + "McuCloudVod.", this.McuCloudVod);
        }
    }
}

