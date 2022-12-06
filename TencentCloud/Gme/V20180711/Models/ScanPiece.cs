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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanPiece : AbstractModel
    {
        
        /// <summary>
        /// Audio retention address, which will be returned for stream detection. The audio will be retained for 30 minutes.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DumpUrl")]
        public string DumpUrl{ get; set; }

        /// <summary>
        /// Whether non-compliant information is detected
        /// </summary>
        [JsonProperty("HitFlag")]
        public bool? HitFlag{ get; set; }

        /// <summary>
        /// Main non-compliant content type
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MainType")]
        public string MainType{ get; set; }

        /// <summary>
        /// Voice detection details
        /// </summary>
        [JsonProperty("ScanDetail")]
        public ScanDetail[] ScanDetail{ get; set; }

        /// <summary>
        /// GME Voice Chat room ID, which is the `RoomId` passed through when the task was submitted.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// GME Voice Chat user ID, which is the `OpenId` passed through when the task was submitted.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// Remarks
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }

        /// <summary>
        /// Offset time of multipart in stream during stream detection (in milliseconds)
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Multipart duration during stream detection
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// Multipart detection start time
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PieceStartTime")]
        public ulong? PieceStartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DumpUrl", this.DumpUrl);
            this.SetParamSimple(map, prefix + "HitFlag", this.HitFlag);
            this.SetParamSimple(map, prefix + "MainType", this.MainType);
            this.SetParamArrayObj(map, prefix + "ScanDetail.", this.ScanDetail);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "Info", this.Info);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "PieceStartTime", this.PieceStartTime);
        }
    }
}

