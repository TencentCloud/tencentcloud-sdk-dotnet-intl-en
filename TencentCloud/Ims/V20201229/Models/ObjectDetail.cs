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

    public class ObjectDetail : AbstractModel
    {
        
        /// <summary>
        /// This parameter is used to return the ID of the recognized object for easier recognition and distinction.
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// This parameter is used to return the hit object tag.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// This parameter is used to return the value or content of the object tag; for example, when the tag is *QR code (QrCode)*, this field will be the URL of the recognized QR code.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// This parameter is used to return the hit score of the object tag. Valid values: **0–100**; for example, *QrCode 99* indicates that it is highly likely that the recognized content will hit the QR code tag.
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// This field is used to return the coordinate position (X and Y coordinates of the top-left corner, length, width, and rotation angle) of the object detection frame for quick location of the object information.
        /// </summary>
        [JsonProperty("Location")]
        public Location Location{ get; set; }

        /// <summary>
        /// This parameter is used to return the hit object subtag.
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
        }
    }
}

