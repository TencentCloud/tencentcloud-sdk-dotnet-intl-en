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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VLPlanResultDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Analysis result ID</p>
        /// </summary>
        [JsonProperty("VLPlanResultId")]
        public string VLPlanResultId{ get; set; }

        /// <summary>
        /// <p>Media type. The current fixed value is image</p>
        /// </summary>
        [JsonProperty("MediaType")]
        public string MediaType{ get; set; }

        /// <summary>
        /// <p>ID of the associated analysis plan</p>
        /// </summary>
        [JsonProperty("VLPlanId")]
        public string VLPlanId{ get; set; }

        /// <summary>
        /// <p>Plan name</p>
        /// </summary>
        [JsonProperty("VLPlanName")]
        public string VLPlanName{ get; set; }

        /// <summary>
        /// <p>Channel ID</p>
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// <p>Channel name</p>
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// <p>Device ID</p>
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// <p>Device name</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>Affiliated organization ID</p>
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// <p>Affiliated organization name</p>
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// <p>Analysis timestamp (seconds)</p>
        /// </summary>
        [JsonProperty("VLResultTimestamp")]
        public long? VLResultTimestamp{ get; set; }

        /// <summary>
        /// <p>Image mode screenshot timestamp (seconds)</p>
        /// </summary>
        [JsonProperty("SnapshotTimestamp")]
        public long? SnapshotTimestamp{ get; set; }

        /// <summary>
        /// <p>Video clip start timestamp (seconds)</p>
        /// </summary>
        [JsonProperty("VideoStartTimestamp")]
        public long? VideoStartTimestamp{ get; set; }

        /// <summary>
        /// <p>Video segment end timestamp (seconds)</p>
        /// </summary>
        [JsonProperty("VideoEndTimestamp")]
        public long? VideoEndTimestamp{ get; set; }

        /// <summary>
        /// <p>Billing method for the number of frames in video mode</p>
        /// </summary>
        [JsonProperty("BilledFrameCount")]
        public long? BilledFrameCount{ get; set; }

        /// <summary>
        /// <p>AI analysis result content (JSON string)</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>Temporary screenshot download URL (valid for 300 seconds)</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>Screenshot URL validity period (seconds)</p>
        /// </summary>
        [JsonProperty("ImageUrlExpire")]
        public long? ImageUrlExpire{ get; set; }

        /// <summary>
        /// <p>Creation time, format: 2006-01-02 15:04:05</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>Update time, format 2006-01-02 15:04:05</p>
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VLPlanResultId", this.VLPlanResultId);
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
            this.SetParamSimple(map, prefix + "VLPlanId", this.VLPlanId);
            this.SetParamSimple(map, prefix + "VLPlanName", this.VLPlanName);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "VLResultTimestamp", this.VLResultTimestamp);
            this.SetParamSimple(map, prefix + "SnapshotTimestamp", this.SnapshotTimestamp);
            this.SetParamSimple(map, prefix + "VideoStartTimestamp", this.VideoStartTimestamp);
            this.SetParamSimple(map, prefix + "VideoEndTimestamp", this.VideoEndTimestamp);
            this.SetParamSimple(map, prefix + "BilledFrameCount", this.BilledFrameCount);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageUrlExpire", this.ImageUrlExpire);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
        }
    }
}

