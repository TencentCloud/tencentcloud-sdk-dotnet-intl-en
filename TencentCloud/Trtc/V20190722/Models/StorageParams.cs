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

    public class StorageParams : AbstractModel
    {
        
        /// <summary>
        /// The account information for third-party storage. Please note that if you save files to COS, a recording-to-COS fee will be incurred. For details, see the document "Billing of On-Cloud Recording". If you save files to VOD, there won't be such a fee.
        /// </summary>
        [JsonProperty("CloudStorage")]
        public CloudStorage CloudStorage{ get; set; }

        /// <summary>
        /// The account information for VOD storage.
        /// </summary>
        [JsonProperty("CloudVod")]
        public CloudVod CloudVod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CloudStorage.", this.CloudStorage);
            this.SetParamObj(map, prefix + "CloudVod.", this.CloudVod);
        }
    }
}

