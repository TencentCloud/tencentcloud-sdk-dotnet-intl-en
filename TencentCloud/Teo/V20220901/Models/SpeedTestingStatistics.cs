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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpeedTestingStatistics : AbstractModel
    {
        
        /// <summary>
        /// Last contentful paint, in milliseconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FirstContentfulPaint")]
        public long? FirstContentfulPaint{ get; set; }

        /// <summary>
        /// Full content load, in milliseconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FirstMeaningfulPaint")]
        public long? FirstMeaningfulPaint{ get; set; }

        /// <summary>
        /// Average download speed, in KB/s.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OverallDownloadSpeed")]
        public float? OverallDownloadSpeed{ get; set; }

        /// <summary>
        /// Rendering time, in milliseconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RenderTime")]
        public long? RenderTime{ get; set; }

        /// <summary>
        /// DOM content loaded, in milliseconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DocumentFinishTime")]
        public long? DocumentFinishTime{ get; set; }

        /// <summary>
        /// Average TCP connection, in milliseconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TcpConnectionTime")]
        public long? TcpConnectionTime{ get; set; }

        /// <summary>
        /// Average backend response, in milliseconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResponseTime")]
        public long? ResponseTime{ get; set; }

        /// <summary>
        /// Average DOM content download, in milliseconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileDownloadTime")]
        public long? FileDownloadTime{ get; set; }

        /// <summary>
        /// Load time, in milliseconds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LoadTime")]
        public long? LoadTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FirstContentfulPaint", this.FirstContentfulPaint);
            this.SetParamSimple(map, prefix + "FirstMeaningfulPaint", this.FirstMeaningfulPaint);
            this.SetParamSimple(map, prefix + "OverallDownloadSpeed", this.OverallDownloadSpeed);
            this.SetParamSimple(map, prefix + "RenderTime", this.RenderTime);
            this.SetParamSimple(map, prefix + "DocumentFinishTime", this.DocumentFinishTime);
            this.SetParamSimple(map, prefix + "TcpConnectionTime", this.TcpConnectionTime);
            this.SetParamSimple(map, prefix + "ResponseTime", this.ResponseTime);
            this.SetParamSimple(map, prefix + "FileDownloadTime", this.FileDownloadTime);
            this.SetParamSimple(map, prefix + "LoadTime", this.LoadTime);
        }
    }
}

