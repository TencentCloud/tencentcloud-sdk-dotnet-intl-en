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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordParam : AbstractModel
    {
        
        /// <summary>
        /// Max recording time per file
        /// Default value: `1800` (seconds)
        /// Value range: 30-7200
        /// This parameter is invalid for HLS. Only one HLS file will be generated from push start to push end.
        /// </summary>
        [JsonProperty("RecordInterval")]
        public long? RecordInterval{ get; set; }

        /// <summary>
        /// Storage duration of the recording file
        /// Value range: 0-129600000 seconds (0-1500 days)
        /// `0`: permanent
        /// </summary>
        [JsonProperty("StorageTime")]
        public long? StorageTime{ get; set; }

        /// <summary>
        /// Whether to enable recording in the current format. Default value: 0. 0: no, 1: yes.
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// VOD subapplication ID.
        /// </summary>
        [JsonProperty("VodSubAppId")]
        public long? VodSubAppId{ get; set; }

        /// <summary>
        /// Recording filename.
        /// Supported special placeholders include:
        /// {StreamID}: stream ID
        /// {StartYear}: start time - year
        /// {StartMonth}: start time - month
        /// {StartDay}: start time - day
        /// {StartHour}: start time - hour
        /// {StartMinute}: start time - minute
        /// {StartSecond}: start time - second
        /// {StartMillisecond}: start time - millisecond
        /// {EndYear}: end time - year
        /// {EndMonth}: end time - month
        /// {EndDay}: end time - day
        /// {EndHour}: end time - hour
        /// {EndMinute}: end time - minute
        /// {EndSecond}: end time - second
        /// {EndMillisecond}: end time - millisecond
        /// 
        /// If this parameter is not set, the recording filename will be `{StreamID}_{StartYear}-{StartMonth}-{StartDay}-{StartHour}-{StartMinute}-{StartSecond}_{EndYear}-{EndMonth}-{EndDay}-{EndHour}-{EndMinute}-{EndSecond}` by default
        /// </summary>
        [JsonProperty("VodFileName")]
        public string VodFileName{ get; set; }

        /// <summary>
        /// Task flow
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// Video storage class. Valid values:
        /// `normal`: STANDARD
        /// `cold`: STANDARD_IA
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// VOD subapplication category
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordInterval", this.RecordInterval);
            this.SetParamSimple(map, prefix + "StorageTime", this.StorageTime);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "VodSubAppId", this.VodSubAppId);
            this.SetParamSimple(map, prefix + "VodFileName", this.VodFileName);
            this.SetParamSimple(map, prefix + "Procedure", this.Procedure);
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
        }
    }
}

