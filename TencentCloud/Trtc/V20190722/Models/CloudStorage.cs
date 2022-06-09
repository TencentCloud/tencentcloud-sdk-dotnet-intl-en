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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudStorage : AbstractModel
    {
        
        /// <summary>
        /// The cloud storage provider.
        /// 0: Tencent Cloud COS. The storage services of other providers are not supported currently.
        /// </summary>
        [JsonProperty("Vendor")]
        public ulong? Vendor{ get; set; }

        /// <summary>
        /// The region of cloud storage.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// The storage bucket.
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// The access_key of the cloud storage account.
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// The secret_key of the cloud storage account.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// The bucket to save data, which is an array of strings that can contain letters (a-z and A-Z), numbers (0-9), underscores (_), and hyphens (-). For example, if the value of this parameter is `["prefix1", "prefix2"]`, the recording file `xxx.m3u8` will be saved as `prefix1/prefix2/TaskId/xxx.m3u8`.
        /// </summary>
        [JsonProperty("FileNamePrefix")]
        public string[] FileNamePrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamArraySimple(map, prefix + "FileNamePrefix.", this.FileNamePrefix);
        }
    }
}

