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

namespace TencentCloud.Ims.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageModerationRequest : AbstractModel
    {
        
        /// <summary>
        /// This field indicates the specific number of the policy, which is used for API scheduling and can be configured in the CMS console. If the `Biztype` parameter is passed in, a moderation policy will be used based on the business scenario; otherwise, the default moderation policy will be used.<br>Note: `Biztype` can contain 3-32 digits, letters, and underscores; different `Biztype` values are associated with different business scenarios and moderation policies, so you need to verify the `Biztype` before calling this API.
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// This field indicates the data ID assigned by you to the object to be detected for easier file identification and management.<br>It **can contain up to 64 letters, digits, and special symbols (_-@#)**.
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// This field indicates the Base64 encoding of the image to be detected. The image **size cannot exceed 5 MB**. **A resolution of 256x256 or higher is recommended**; otherwise, the recognition effect may be affected.<br>Note: **you must enter a value for either this field or `FileUrl`**.
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// URL of the image to moderate. It supports PNG, JPG, JPEG, BMP, GIF AND WEBP files. The file **cannot exceed 5 MB** and the resolution should not below **256*246**. The default timeout period is 3 seconds. Note that **redirection URLs may be blocked by security policies**. In this case, an error message will return. For example, if an HTTP request gets the 302 code, the error `ResourceUnavailable.ImageDownloadError` is returned. <br>**Either `FileUrl` or `FileContent` must be specified. 
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// **For GIF/long image detection only**. This field indicates the GIF frame capturing frequency (the image interval for capturing a frame for detection). For long images, you should round the width:height ratio as the total number of images to be split. The default value is 0, where only the first frame of the GIF image will be detected, and the long image will not be split.<br>Note: the `Interval` and `MaxFrames` parameters need to be used in combination; for example, if `Interval` is `3` and `MaxFrames` is `400`, the GIF/long image will be detected once every two frames for up to 400 frames.
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// **For GIF/long image detection only**. This field indicates the maximum number of frames that can be captured. The default value is 1, where only the first frame of the input GIF image will be detected, and the long image will not be split (which may cause a processing timeout).<br>Note: the `Interval` and `MaxFrames` parameters need to be used in combination; for example, if `Interval` is `3` and `MaxFrames` is `400`, the GIF/long image will be detected once every two frames for up to 400 frames.
        /// </summary>
        [JsonProperty("MaxFrames")]
        public long? MaxFrames{ get; set; }

        /// <summary>
        /// This field indicates the information of the user that corresponds to the object to be detected. It can be passed in to identify the user involved in the violation.
        /// </summary>
        [JsonProperty("User")]
        public User User{ get; set; }

        /// <summary>
        /// This field indicates the information of the device that corresponds to the object to be detected. It can be passed in to identify the device involved in the violation.
        /// </summary>
        [JsonProperty("Device")]
        public Device Device{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "MaxFrames", this.MaxFrames);
            this.SetParamObj(map, prefix + "User.", this.User);
            this.SetParamObj(map, prefix + "Device.", this.Device);
        }
    }
}

