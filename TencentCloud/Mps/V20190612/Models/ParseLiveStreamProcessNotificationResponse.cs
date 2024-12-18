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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParseLiveStreamProcessNotificationResponse : AbstractModel
    {
        
        /// <summary>
        /// Live stream processing result type, including:
        /// <li>AiReviewResult: content auditing result.</li>
        /// <li>AiRecognitionResult: content recognition result.</li>
        /// <li>LiveRecordResult: live recording result.</li>
        /// <li>AiQualityControlResult: media quality inspection result.</li>
        /// <li>ProcessEof: live stream processing result.</li>
        /// </summary>
        [JsonProperty("NotificationType")]
        public string NotificationType{ get; set; }

        /// <summary>
        /// Video processing task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Information of a live stream processing error, which is valid when `NotificationType` is `ProcessEof`.
        /// Note: when this field return null, means no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessEofInfo")]
        public LiveStreamProcessErrorInfo ProcessEofInfo{ get; set; }

        /// <summary>
        /// Content audit result, which is valid when `NotificationType` is `AiReviewResult`.
        /// Note: when this field return null, means no valid values can be obtained.
        /// </summary>
        [JsonProperty("AiReviewResultInfo")]
        public LiveStreamAiReviewResultInfo AiReviewResultInfo{ get; set; }

        /// <summary>
        /// Content recognition result, which is valid if `NotificationType` is `AiRecognitionResult`.
        /// </summary>
        [JsonProperty("AiRecognitionResultInfo")]
        public LiveStreamAiRecognitionResultInfo AiRecognitionResultInfo{ get; set; }

        /// <summary>
        /// Content analysis result, which is valid if `NotificationType` is `AiAnalysisResult`.
        /// </summary>
        [JsonProperty("AiAnalysisResultInfo")]
        public LiveStreamAiAnalysisResultInfo AiAnalysisResultInfo{ get; set; }

        /// <summary>
        /// Media quality inspection result, which is valid if `NotificationType` is `AiQualityControlResult`.
        /// </summary>
        [JsonProperty("AiQualityControlResultInfo")]
        public LiveStreamAiQualityControlResultInfo AiQualityControlResultInfo{ get; set; }

        /// <summary>
        /// Live recording result is valid when NotificationType is LiveRecordResult.
        /// Note: when this field return null, means no valid values can be obtained.
        /// </summary>
        [JsonProperty("LiveRecordResultInfo")]
        public LiveStreamRecordResultInfo LiveRecordResultInfo{ get; set; }

        /// <summary>
        /// The ID used for deduplication. If there was a request with the same ID in the last seven days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// - Expiration time, event notification signature expiration UNIX timestamp. - By default, notifications sent by MPS expire after 10 minutes. If the expiration time specified has elapsed, a notification will be considered invalid. This can prevent replay attacks. - The format of Timestamp is a decimal UNIX timestamp, which is the number of seconds that have elapsed since January 1, 1970 (midnight UTC/GMT).
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// Event notification security signature. Sign = MD5 (Timestamp + NotifyKey). Note: Media Processing Service concatenates Timestamp and NotifyKey from TaskNotifyConfig as a string and calculates the Sign value through MD5. This value is included in the notification message. Your backend server can verify whether the Sign is correct using the same algorithm, to confirm whether the message is indeed from the Media Processing Service backend.
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Sign")]
        public string Sign{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotificationType", this.NotificationType);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamObj(map, prefix + "ProcessEofInfo.", this.ProcessEofInfo);
            this.SetParamObj(map, prefix + "AiReviewResultInfo.", this.AiReviewResultInfo);
            this.SetParamObj(map, prefix + "AiRecognitionResultInfo.", this.AiRecognitionResultInfo);
            this.SetParamObj(map, prefix + "AiAnalysisResultInfo.", this.AiAnalysisResultInfo);
            this.SetParamObj(map, prefix + "AiQualityControlResultInfo.", this.AiQualityControlResultInfo);
            this.SetParamObj(map, prefix + "LiveRecordResultInfo.", this.LiveRecordResultInfo);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Sign", this.Sign);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

