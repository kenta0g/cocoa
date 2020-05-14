﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Radar.Models
{
	public class DiagnosisSubmissionParameter : IUser
	{
		[JsonProperty("submissionNumber")]
		public string SubmissionNumber { get; set; }
		[JsonProperty("userUuid")]
		public string UserUuid { get; set; }
        [JsonProperty("keys")]
		public TemporaryExposureKeyModel[] Keys { get; set; }

	}
}
