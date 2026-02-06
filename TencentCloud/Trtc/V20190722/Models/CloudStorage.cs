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

    public class CloudStorage : AbstractModel
    {
        
        /// <summary>
        /// The cloud storage provider.
        /// `0`: Tencent Cloud COS; `1`: AWS storage. Other vendors are not supported currently.
        /// </summary>
        [JsonProperty("Vendor")]
        public ulong? Vendor{ get; set; }

        /// <summary>
        /// [Region information](https://www.tencentcloud.comom/document/product/436/6224?from_cn_redirect=1#.E5.9C.B0.E5.9F.9F) of tencent cloud object storage.
        /// Example value: cn-shanghai-1.
        /// 
        /// [Region information](https://docs.AWS.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html#concepts-regions) of AWS S3.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// The storage bucket.
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// access_key account information of the cloud storage.
        /// To store files to tencent cloud object storage (COS), visit https://console.cloud.tencent.com/cam/capi to view or create the SecretId value corresponding to the key fields in the link.
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// secret_key account information of the cloud storage.
        /// To store files to tencent cloud object storage (COS), visit https://console.cloud.tencent.com/cam/capi to view or create the SecretKey value corresponding to the key fields in the link.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// The specified position of the cloud storage bucket consists of an array of strings. valid values: az, az, 0-9, '_', and '-'. for example, the recording file xxx.m3u8 becomes prefix1/prefix2/TaskId/xxx.m3u8 under the function of ["prefix1", "prefix2"].
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

