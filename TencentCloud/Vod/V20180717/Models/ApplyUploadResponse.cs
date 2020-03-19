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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyUploadResponse : AbstractModel
    {
        
        /// <summary>
        /// Bucket, which is used as the `bucket_name` in the URL of the upload API.
        /// </summary>
        [JsonProperty("StorageBucket")]
        public string StorageBucket{ get; set; }

        /// <summary>
        /// Storage region, which is used as the `Region` in the `Host` of the upload API.
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// VOD session, which is used to confirm the `VodSessionKey` parameter of the upload API.
        /// </summary>
        [JsonProperty("VodSessionKey")]
        public string VodSessionKey{ get; set; }

        /// <summary>
        /// Media storage path, which is used as the `Key` of the stored media of the upload API.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MediaStoragePath")]
        public string MediaStoragePath{ get; set; }

        /// <summary>
        /// Cover storage path, which is used as the `Key` of the stored cover of the upload API.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoverStoragePath")]
        public string CoverStoragePath{ get; set; }

        /// <summary>
        /// Temporary credential, which is used for authentication of the upload API.
        /// </summary>
        [JsonProperty("TempCertificate")]
        public TempCertificate TempCertificate{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageBucket", this.StorageBucket);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "VodSessionKey", this.VodSessionKey);
            this.SetParamSimple(map, prefix + "MediaStoragePath", this.MediaStoragePath);
            this.SetParamSimple(map, prefix + "CoverStoragePath", this.CoverStoragePath);
            this.SetParamObj(map, prefix + "TempCertificate.", this.TempCertificate);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

