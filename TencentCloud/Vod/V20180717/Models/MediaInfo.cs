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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaInfo : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BasicInfo")]
        public MediaBasicInfo BasicInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TranscodeInfo")]
        public MediaTranscodeInfo TranscodeInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AnimatedGraphicsInfo")]
        public MediaAnimatedGraphicsInfo AnimatedGraphicsInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SampleSnapshotInfo")]
        public MediaSampleSnapshotInfo SampleSnapshotInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ImageSpriteInfo")]
        public MediaImageSpriteInfo ImageSpriteInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetInfo")]
        public MediaSnapshotByTimeOffsetInfo SnapshotByTimeOffsetInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("KeyFrameDescInfo")]
        public MediaKeyFrameDescInfo KeyFrameDescInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingInfo")]
        public MediaAdaptiveDynamicStreamingInfo AdaptiveDynamicStreamingInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MiniProgramReviewInfo")]
        public MediaMiniProgramReviewInfo MiniProgramReviewInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleInfo")]
        public MediaSubtitleInfo SubtitleInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReviewInfo")]
        public FileReviewInfo ReviewInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MPSAiMediaInfo")]
        public MPSAiMediaInfo MPSAiMediaInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ImageUnderstandingInfo")]
        public ImageUnderstandingInfo ImageUnderstandingInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("KnowledgeBasesInfo")]
        public KnowledgeBasesInfo KnowledgeBasesInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FaceRecognitionInfo")]
        public FaceRecognitionInfo FaceRecognitionInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BasicInfo.", this.BasicInfo);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamObj(map, prefix + "TranscodeInfo.", this.TranscodeInfo);
            this.SetParamObj(map, prefix + "AnimatedGraphicsInfo.", this.AnimatedGraphicsInfo);
            this.SetParamObj(map, prefix + "SampleSnapshotInfo.", this.SampleSnapshotInfo);
            this.SetParamObj(map, prefix + "ImageSpriteInfo.", this.ImageSpriteInfo);
            this.SetParamObj(map, prefix + "SnapshotByTimeOffsetInfo.", this.SnapshotByTimeOffsetInfo);
            this.SetParamObj(map, prefix + "KeyFrameDescInfo.", this.KeyFrameDescInfo);
            this.SetParamObj(map, prefix + "AdaptiveDynamicStreamingInfo.", this.AdaptiveDynamicStreamingInfo);
            this.SetParamObj(map, prefix + "MiniProgramReviewInfo.", this.MiniProgramReviewInfo);
            this.SetParamObj(map, prefix + "SubtitleInfo.", this.SubtitleInfo);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamObj(map, prefix + "ReviewInfo.", this.ReviewInfo);
            this.SetParamObj(map, prefix + "MPSAiMediaInfo.", this.MPSAiMediaInfo);
            this.SetParamObj(map, prefix + "ImageUnderstandingInfo.", this.ImageUnderstandingInfo);
            this.SetParamObj(map, prefix + "KnowledgeBasesInfo.", this.KnowledgeBasesInfo);
            this.SetParamObj(map, prefix + "FaceRecognitionInfo.", this.FaceRecognitionInfo);
        }
    }
}

