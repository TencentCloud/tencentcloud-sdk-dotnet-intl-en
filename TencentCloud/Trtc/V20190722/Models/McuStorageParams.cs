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
        /// Third-Party Cloud Storage Account Information
        /// (Note: Storing files in Object Storage COS will incur recording file delivery fees. For details, see [Cloud Recording Billing]. Storing in VOD does not incur this fee.)
        /// Example:{"Vendor":0,"Region":"ap-shanghai","Bucket":"*","AccessKey":"*","SecretKey":"***","FileNamePrefix":["mcu_record"]}
        /// </summary>
        [JsonProperty("CloudStorage")]
        public CloudStorage CloudStorage{ get; set; }

        /// <summary>
        /// Tencent Cloud VOD Account Information
        /// Example:{"McuTencentVod":{"ExpireTime":86400}}
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

