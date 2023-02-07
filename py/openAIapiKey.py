# 

import openai

# Replace YOUR_API_KEY with your actual API key
openai.api_key = "YOUR_API_KEY"

# Example API request
model_engine = "text-davinci-002"
prompt = "What is the meaning of life?"

completions = openai.Completion.create(
    engine=model_engine,
    prompt=prompt,
    max_tokens=1024,
    n=1,
    stop=None,
    temperature=0.5,
)

message = completions.choices[0].text
print(message)
